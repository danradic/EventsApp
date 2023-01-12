using EventsApp.Application.Contracts.Persistence;
using EventsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Activity>> GetActivitiesWithAttendees(bool includePassedActivites)
        {
            var activities = await _dbContext.Activities.Include(x => x.Attendees).ToListAsync();

            if(!includePassedActivites)
            {
                activities.RemoveAll(c => c.Date < DateTime.Today);
            }

            return activities;
        }

    }
}