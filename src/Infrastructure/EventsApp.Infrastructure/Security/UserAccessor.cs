using System.Security.Claims;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Errors;
using EventsApp.Application.Models;
using EventsApp.Application.Responses;
using EventsApp.Identity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
            
            var appUser = await _userManager.Users
                .FirstOrDefaultAsync(x => x.Id == claimsPrincipal.FindFirstValue("uid"));

            if (appUser == null)
                return Result<User>.Failure(errorType: ErrorType.NotFound, message: "User not found.");

            var user = new User
            {
                UserId = appUser.Id,
                DisplayName = appUser.DisplayName,
                Email = appUser.Email,
                Image = null,
                UserName = appUser.UserName,
                Bio = appUser.Bio
            };

            return Result<User>.Success(user);
        }
    }
}