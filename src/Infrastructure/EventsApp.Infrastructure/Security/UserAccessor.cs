using System.Security.Claims;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Errors;
using EventsApp.Application.Models;
using EventsApp.Application.Responses;
using EventsApp.Identity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace EventsApp.Infrastructure.Security
{
    public class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserAccessor(IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Result<User>> GetCurrentUser()
        {
            var claimsPrincipal = _httpContextAccessor.HttpContext?.User;
            var appUser = await _userManager.FindByEmailAsync(claimsPrincipal.FindFirstValue(ClaimTypes.Email));

            if (appUser == null)
                return Result<User>.Failure(errorType: ErrorType.NotFound, message: "User not found.");

            var user = new User
            {
                Id = appUser.Id,
                DisplayName = appUser.DisplayName,
                Image = null,
                UserName = appUser.UserName
            };

            return Result<User>.Success(user);
        }
    }
}