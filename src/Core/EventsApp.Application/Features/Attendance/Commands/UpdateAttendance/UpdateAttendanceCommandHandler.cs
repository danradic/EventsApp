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
        public UpdateAttendanceCommandHandler(IActivityRepository activityRepository, IUserAccessor userAccessor)
        {
            _activityRepository = activityRepository;
            _userAccessor = userAccessor;
        }

        public async Task<Result<Unit>> Handle(UpdateAttendanceCommand request, CancellationToken cancellationToken)
        {
            var activity = await _activityRepository.GetActivityDetailWithAttendees(request.Id);

            if(activity == null)
                return Result<Unit>.Failure(errorType:ErrorType.NotFound, message: $"Activity with id {request.Id} not found.");

            var currentUserResult = await _userAccessor.GetCurrentUser();

            if(!currentUserResult.IsSuccess || currentUserResult.Value == null)
                return Result<Unit>.Failure(errorType: ErrorType.NotFound, message: "Current user not found");

            var currentUsername = currentUserResult.Value.UserName;
            var hostUsername = activity.Attendees.FirstOrDefault(x => x.IsHost)?.UserName;
            var activityAttendee = activity.Attendees.FirstOrDefault(x => x.UserName == currentUsername);
            bool isCurrentUserAnAttendee = activityAttendee != null;
            bool isCurrentUserHost = isCurrentUserAnAttendee && currentUsername == hostUsername;

            if(isCurrentUserHost) activity.IsCancelled = !activity.IsCancelled;
            if(!isCurrentUserHost) activity.Attendees.Remove(activityAttendee);

            if(!isCurrentUserAnAttendee)
            {
                activityAttendee = new ActivityAttendee
                {
                    Activity = activity,
                    UserId = currentUserResult.Value.Id,
                    DisplayName = currentUserResult.Value.DisplayName,
                    UserName = currentUserResult.Value.UserName,
                    Email = currentUserResult.Value.Email,
                    Bio = currentUserResult.Value.Bio,
                    Image = currentUserResult.Value.Image,
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