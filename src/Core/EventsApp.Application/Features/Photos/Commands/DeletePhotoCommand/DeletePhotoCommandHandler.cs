using AutoMapper;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Contracts.Infrastructure.Services.Photos;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Photos.Commands.DeletePhotoCommand
{
    public class DeletePhotoCommandHandler : IRequestHandler<DeletePhotoCommand, Result<Unit>>
    {
        private readonly IPhotoRepository _photoRepository;
        private readonly IPhotoCloudStorageService _photoCloudStorageService;
        private readonly IUserAccessor _userAccessor;

        public DeletePhotoCommandHandler(
            IPhotoRepository photoRepository,
            IPhotoCloudStorageService photoCloudStorageService,
            IUserAccessor userAccessor)
        {
            _photoRepository = photoRepository;
            _photoCloudStorageService = photoCloudStorageService;
            _userAccessor = userAccessor;
        }
        public async Task<Result<Unit>> Handle(DeletePhotoCommand request, CancellationToken cancellationToken)
        {
            var currentUserResult = _userAccessor.GetUser();

            if (!currentUserResult.Result.IsSuccess)
                return Result<Unit>.Failure(errorType: currentUserResult.Result.ErrorType, message: currentUserResult.Result.Message);

            var currentUser = currentUserResult.Result.Value;
            var photoToDelete = await _photoRepository.GetByIdAsync(request.PhotoId);

            if (photoToDelete == null)
                return Result<Unit>.Failure(errorType: ErrorType.NotFound, message: "Photo not found.");

            if (photoToDelete.IsMain)
                return Result<Unit>.Failure(errorType: ErrorType.Validation, message: "You cannot delete your main photo.");

            var isPhotoDeletedFromDatabase = await _photoRepository.DeleteAsync(photoToDelete) > 0;

            if (!isPhotoDeletedFromDatabase)
                return Result<Unit>.Failure(errorType: ErrorType.Failure, message: "Problem deleting photo from database.");

            var deleteCloudPhotoResult = await _photoCloudStorageService.DeletePhoto(photoToDelete.Id);

            if (deleteCloudPhotoResult == null)
                Result<Unit>.Failure(errorType: ErrorType.Failure, message: "Problem deleting photo from cloud service.");

            return Result<Unit>.Success(Unit.Value);
        }
    }
}