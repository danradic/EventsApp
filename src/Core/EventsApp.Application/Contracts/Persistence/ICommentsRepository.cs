using EventsApp.Domain.Entities;

namespace EventsApp.Application.Contracts.Persistence
{
    public interface ICommentsRepository : IRepositoryAsync<Comment>
    {
        Task<List<Comment>> GetCommentsByActivityId(Guid activityId);
        
    }
}