using EventsApp.Application.Contracts.Persistence;
using EventsApp.Domain.Entities;

namespace EventsApp.Persistence.Repositories
{
    public class PhotoRepository : BaseRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(EventsAppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<Photo>> GetPhotosByUserId(string userId)
        {
            var photos = _dbContext.Photos.Where(a => a.ApplicationUserId == userId).ToList();

            return Task.FromResult(photos);
        }
    }
}