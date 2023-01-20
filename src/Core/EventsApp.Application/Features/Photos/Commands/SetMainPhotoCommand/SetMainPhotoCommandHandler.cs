using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Photos.Commands.SetMainPhotoCommand
{
    public class SetMainPhotoCommandHandler : IRequestHandler<SetMainPhotoCommand, Result<Unit>>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly IPhotoRepository _photoRepository;
        private readonly IActivityRepository _activityRepository;

        public SetMainPhotoCommandHandler(
            IUserAccessor userAccessor,
            IPhotoRepository photoRepository, 
            IActivityRepository activityRepository)
        {
            _userAccessor = userAccessor;
            _photoRepository = photoRepository;
            _activityRepository = activityRepository;
        }

        public async Task<Result<Unit>> Handle(SetMainPhotoCommand request, CancellationToken cancellationToken)
        {
            var currentUserResult = _userAccessor.GetUser();

            if (!currentUserResult.Result.IsSuccess)
                return Result<Unit>.Failure(errorType: currentUserResult.Result.ErrorType, message: currentUserResult.Result.Message);

            var currentUser = currentUserResult.Result.Value;

            var mainPhoto = await _photoRepository.SetMainPhoto(currentUser.UserId, request.PhotoId);

            if (mainPhoto == null)
                return Result<Unit>.Failure(errorType: ErrorType.Failure, message: "Problem setting main photo.");

            await _activityRepository.UpdateActivityAttendeeImage(currentUser.UserId, mainPhoto.Url);
            
            return Result<Unit>.Success(Unit.Value);
        }
    }
}