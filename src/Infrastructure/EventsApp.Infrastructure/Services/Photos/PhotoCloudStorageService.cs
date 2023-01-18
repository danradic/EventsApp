using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using EventsApp.Application.Contracts.Infrastructure.Services.Photos;
using EventsApp.Application.Features.Photos.Commands.CreatePhotoCommand;
using Microsoft.Extensions.Options;

namespace EventsApp.Infrastructure.Services.Photos
{
    public class PhotoCloudStorageService : IPhotoCloudStorageService
    {
        private readonly Cloudinary _cloudinary;
        public PhotoCloudStorageService(IOptions<CloudinarySettings> config)
        {
            var account = new Account
            (
                config.Value.CloudName,
                config.Value.ApiKey,
                config.Value.ApiSecret
            );
            _cloudinary = new Cloudinary(account);
        }

        public async Task<string> DeletePhoto(string publicId)
        {
           var deleteParams = new DeletionParams(publicId);
           var result = await _cloudinary.DestroyAsync(deleteParams);

           return result.Result == "ok" ? result.Result : null;
        }

        public async Task<PhotoUploadResult> UploadPhoto(IFormFileProxy file)
        {
            if (file.Length <= 0) return null;

            await using var stream = file.OpenReadStream();
            
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, stream),
                Transformation = new Transformation().Height(500).Width(500).Crop("fill")
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
            {
                throw new Exception(uploadResult.Error.Message);
            }

            return new PhotoUploadResult
            {
                PublicId = uploadResult.PublicId,
                Url = uploadResult.SecureUrl.ToString()
            };
        }
    }
}