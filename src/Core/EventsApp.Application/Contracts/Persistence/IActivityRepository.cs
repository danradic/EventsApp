using EventsApp.Domain.Entities;

namespace EventsApp.Application.Contracts.Persistence
{
    public interface IActivityRepository : IRepositoryAsync<Activity>
    {
        Task<bool> IsActivityTitleAndDateUnique(string title, DateTime date);
        Task<List<Activity>> GetActivitiesWithAttendees(bool includePassedActivites);
        Task<Activity> GetActivityDetailWithAttendees(Guid id);
    }
}