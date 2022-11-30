using EventsApp.Application.Contracts.Persistence;
using EventsApp.Domain.Entities;

namespace EventsApp.Persistence.Repositories
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(EventsAppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsActivityTitleAndDateUnique(string title, DateTime date)
        {
            var matches = _dbContext.Activities.Any(a => a.Title.Equals(title) && a.Date.Equals(date));

            return Task.FromResult(matches);
        }
    }
}