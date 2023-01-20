using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
using EventsApp.Application.Responses;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Attendance.Commands.UpdateAttendance
{
    public class UpdateAttendanceCommandHandler : IRequestHandler<UpdateAttendanceCommand, Result<Unit>>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly IActivityRepository _activityRepository;
        private readonly IPhotoRepository _photoRepository;

        public UpdateAttendanceCommandHandler(
            IActivityRepository activityRepository,
            IUserAccessor userAccessor,
            IPhotoRepository photoRepository)
        {
            _activityRepository = activityRepository;
            _userAccessor = userAccessor;
            _photoRepository = photoRepository;
        }

        public async Task<Result<Unit>> Handle(UpdateAttendanceCommand request, CancellationToken cancellationToken)
        {
            var activity = await _activityRepository.GetActivityDetailWithAttendees(request.Id);

            if(activity == null)
                return Result<Unit>.Failure(errorType:ErrorType.NotFound, message: $"Activity with id {request.Id} not found.");

            var currentUserResult = await _userAccessor.GetUser();

            if(!currentUserResult.IsSuccess || currentUserResult.Value == null)
                return Result<Unit>.Failure(errorType: ErrorType.NotFound, message: "Current user not found");

            var currentUser = currentUserResult.Value;

            var currentUserMainPhoto = await _photoRepository.GetMainPhoto(currentUser.UserId);
            if(currentUserMainPhoto != null) currentUser.Image = currentUserMainPhoto.Url;

            var hostUsername = activity.Attendees.FirstOrDefault(x => x.IsHost)?.UserName;
            var activityAttendee = activity.Attendees.FirstOrDefault(x => x.UserName == currentUser.UserName);
            bool isCurrentUserAnAttendee = activityAttendee != null;
            bool isCurrentUserHost = isCurrentUserAnAttendee && currentUser.UserName == hostUsername;

            if(isCurrentUserHost) activity.IsCancelled = !activity.IsCancelled;
            if(!isCurrentUserHost) activity.Attendees.Remove(activityAttendee);

            if(!isCurrentUserAnAttendee)
            {
                activityAttendee = new ActivityAttendee 
                {
                    Activity = activity,
                    UserId = currentUser.UserId,
                    DisplayName = currentUser.DisplayName,
                    UserName = currentUser.UserName,
                    Email = currentUser.Email,
                    Bio = currentUser.Bio,
                    Image = currentUser.Image,
                    IsHost = false
                };
                activity.Attendees.Add(activityAttendee);
            }

            bool isActivityUpdated = await _activityRepository.UpdateAsync(activity) > 0;

            return isActivityUpdated ? 
                Result<Unit>.Success(Unit.Value) : 
                Result<Unit>.Failure(errorType: ErrorType.Failure, message: "Problem updating attendance");
        }
    }
}