using EventsApp.Application.Contracts.Persistence;
using EventsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventsApp.Persistence.Repositories
{
    public class PhotoRepository : BaseRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(EventsAppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Photo>> GetPhotosByUserId(string userId)
        {
            return await _dbContext.Photos.Where(a => a.ApplicationUserId == userId).ToListAsync();
        }

        public async Task<List<Photo>> GetMainPhotos(List<string> userIds)
        {
            return await _dbContext.Photos
                .Where(a => userIds.Contains(a.ApplicationUserId) && a.IsMain == true)
                .ToListAsync();
        }

        public async Task<Photo> GetMainPhoto(string userId)
        {
            return await _dbContext.Photos.FirstOrDefaultAsync(a => a.ApplicationUserId == userId && a.IsMain);
        }

        public async Task<Photo> SetMainPhoto(string userId, string photoId)
        {
            var photoToSetAsMain = _dbContext.Photos.FirstOrDefault(a => a.ApplicationUserId == userId && a.Id == photoId);
            
            if(photoToSetAsMain == null) return null;

            photoToSetAsMain.IsMain = true;

            var allOtherPhotos = await _dbContext.Photos.Where(a => a.ApplicationUserId == userId && a.Id != photoId).ToListAsync();

            foreach (var photo in allOtherPhotos)
            {
                photo.IsMain = false;
            }

            await _dbContext.SaveChangesAsync();

            return photoToSetAsMain;
        }
    }
}