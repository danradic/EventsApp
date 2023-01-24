using EventsApp.Application.Contracts.Persistence;
using EventsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventsApp.Persistence.Repositories
{
    public class CommentsRepository : BaseRepository<Comment>, ICommentsRepository
    {
        public CommentsRepository(EventsAppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Comment>> GetCommentsByActivityId(Guid activityId)
        {
            return await _dbContext.Comments.Where(c => c.Activity.Id == activityId)
                .OrderByDescending(c => c.CreatedAt)
                .ToListAsync();
        }
    }
}