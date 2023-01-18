using EventsApp.Application.Features.Photos.Commands.CreatePhotoCommand;

namespace EventsApp.Application.Contracts.Infrastructure.Services.Photos
{
    public interface IPhotoCloudStorageService
    {
        Task<PhotoUploadResult> UploadPhoto(IFormFileProxy file);
        Task<string> DeletePhoto(string publicId);
    }
}