using EventsApp.Application.Models;
using EventsApp.Application.Responses;

namespace EventsApp.Application.Contracts.Infrastructure.Security
{
    public interface IUserAccessor
    {
        Task<Result<User>> GetUser(string userId = null);
    }
}