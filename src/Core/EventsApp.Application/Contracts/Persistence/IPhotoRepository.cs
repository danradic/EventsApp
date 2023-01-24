using EventsApp.Domain.Entities;

namespace EventsApp.Application.Contracts.Persistence
{
    public interface IPhotoRepository : IRepositoryAsync<Photo>
    {
        Task<List<Photo>> GetPhotosByUserId(string userId);
        Task<Photo> GetMainPhoto(string userId);
        Task<List<Photo>> GetMainPhotos(List<string> userId);
        Task<Photo> SetMainPhoto(string userId, string photoId);
    }
}