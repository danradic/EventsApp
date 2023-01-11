using EventsApp.Application.Models;
using EventsApp.Application.Responses;

namespace EventsApp.Application.Contracts
{
    public interface IUserAccessor
    {
        Task<Result<User>> GetCurrentUser();
    }
}