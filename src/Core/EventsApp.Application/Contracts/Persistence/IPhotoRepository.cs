using EventsApp.Domain.Entities;

namespace EventsApp.Application.Contracts.Persistence
{
    public interface IPhotoRepository : IRepositoryAsync<Photo>
    {
        Task<List<Photo>> GetPhotosByUserId(string userId);
        Task<Photo> GetMainPhoto(string userId);
        Task<int> SetMainPhoto(string userId, string photoId);
    }
}