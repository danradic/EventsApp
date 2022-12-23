using EventsApp.Application.Models.Authentication;
using EventsApp.Application.Contracts.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IAuthenticationService _authenticationService;
        public AccountController(IAuthenticationService authenticationService )
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            return HandleResult(await _authenticationService.AuthenticateAsync(request));
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegistrationRequest request)
        {
            return HandleResult(await _authenticationService.RegisterAsync(request));
        }
    }
}