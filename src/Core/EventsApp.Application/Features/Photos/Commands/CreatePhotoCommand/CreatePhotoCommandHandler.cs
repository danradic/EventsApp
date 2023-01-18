using AutoMapper;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Contracts.Infrastructure.Services.Photos;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Responses;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Photos.Commands.CreatePhotoCommand
{
    public class CreatePhotoCommandHandler : IRequestHandler<CreatePhotoCommand, Result<PhotoViewModel>>
    {
        private readonly IPhotoCloudStorageService _photoCloudStorageService;
        private readonly IUserAccessor _userAccessor;
        private readonly IMapper _mapper;
        private readonly IPhotoRepository _photoRepository;

        public CreatePhotoCommandHandler(
            IPhotoRepository photoRepository, 
            IPhotoCloudStorageService photoCloudStorageService,
            IUserAccessor userAccessor,
            IMapper mapper)
        {
            _photoRepository = photoRepository;
            _photoCloudStorageService = photoCloudStorageService;
            _userAccessor = userAccessor;
            _mapper = mapper;
        }

        public async Task<Result<PhotoViewModel>> Handle(CreatePhotoCommand request, CancellationToken cancellationToken)
        {

            var currentUserResult = _userAccessor.GetCurrentUser();

            if (!currentUserResult.Result.IsSuccess)
                return Result<PhotoViewModel>.Failure(errorType: currentUserResult.Result.ErrorType, message: currentUserResult.Result.Message);

            var currentUser = currentUserResult.Result.Value;
            var currentUserPhotos = await _photoRepository.GetPhotosByUserId(currentUser.UserId);

            var photoUploadToCloudResult = await _photoCloudStorageService.UploadPhoto(request.File);

            var photo = new PhotoViewModel
            {
                Id = photoUploadToCloudResult.PublicId,
                ApplicationUserId = currentUser.UserId,
                Url = photoUploadToCloudResult.Url
            };

            if(!currentUserPhotos.Any(x => x.IsMain)) photo.IsMain = true;

            var isPhotoCreated = await _photoRepository.AddAsync(_mapper.Map<Photo>(photo)) > 0;

            return isPhotoCreated ? 
                Result<PhotoViewModel>.Success(photo) :
                Result<PhotoViewModel>.Failure(errorType: Errors.ErrorType.Failure, message: "Problem creating photo.");
                 
        }
    }
}