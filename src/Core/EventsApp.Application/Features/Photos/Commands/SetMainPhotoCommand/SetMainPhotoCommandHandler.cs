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

        public SetMainPhotoCommandHandler(
            IUserAccessor userAccessor,
            IPhotoRepository photoRepository)
        {
            _userAccessor = userAccessor;
            _photoRepository = photoRepository;
        }

        public async Task<Result<Unit>> Handle(SetMainPhotoCommand request, CancellationToken cancellationToken)
        {
            var currentUserResult = _userAccessor.GetCurrentUser();

            if (!currentUserResult.Result.IsSuccess)
                return Result<Unit>.Failure(errorType: currentUserResult.Result.ErrorType, message: currentUserResult.Result.Message);

            var currentUser = currentUserResult.Result.Value;

            var setMainPhotoResult = await _photoRepository.SetMainPhoto(currentUser.UserId, request.PhotoId) > 0;

            if (!setMainPhotoResult)
                return Result<Unit>.Failure(errorType: ErrorType.Failure, message: "Problem setting main photo.");

            return Result<Unit>.Success(Unit.Value);
        }
    }
}