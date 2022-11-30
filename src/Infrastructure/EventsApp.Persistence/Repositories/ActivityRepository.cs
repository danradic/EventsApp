using EventsApp.Application.Contracts.Persistence;
using EventsApp.Domain.Entities;

namespace EventsApp.Persistence.Repositories
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(EventsAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}