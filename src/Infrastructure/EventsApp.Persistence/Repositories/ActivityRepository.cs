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

        public Task<Activity> GetActivityDetailWithAttendees(Guid id)
        {
            var activityDetail = _dbContext.Activities.Where(a => a.Id == id).Include(x => x.Attendees).FirstOrDefault();

            return Task.FromResult(activityDetail);
        }

        public async Task<int> UpdateActivityAttendeeImage(string userId, string imageUrl)
        {
            var activities = _dbContext.Activities.Include(x => x.Attendees.Where(a => a.UserId == userId));

            if(activities == null) return 0;

            foreach (var activity in activities)
            {
                foreach (var attendee in activity.Attendees)
                {
                    attendee.Image = imageUrl;
                }
            }

            return await _dbContext.SaveChangesAsync();
        }
    }
}