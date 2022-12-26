using EventsApp.Application.Models.Authentication;
using EventsApp.Application.Responses;

namespace EventsApp.Application.Contracts.Identity
{
    public interface IAuthenticationService
    {
        Task<Result<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request);
        Task<Result<RegistrationResponse>> RegisterAsync(RegistrationRequest request);
        Task<Result<AuthenticationResponse>> GetCurrentUser();
        Task Logout();
    }
}