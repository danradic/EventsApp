using EventsApp.Domain.Entities;

namespace EventsApp.Application.Contracts.Persistence
{
    public interface IActivityRepository : IRepositoryAsync<Activity>
    {
    }
}