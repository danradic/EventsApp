using System.Security.Claims;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Errors;
using EventsApp.Application.Models;
using EventsApp.Application.Responses;
using EventsApp.Identity.Models;
using EventsApp.Identity.Profiles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EventsApp.Infrastructure.Security
{
    public class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;
        
        public UserAccessor(
            IHttpContextAccessor httpContextAccessor, 
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Result<User>> GetUser(string userId = null)
        {
            ApplicationUser appUser = new();

            bool getCurrentUser = userId == null;

            if (getCurrentUser)
            {
                var claimsPrincipal = _httpContextAccessor.HttpContext?.User;
                appUser = await _userManager.Users
                    .FirstOrDefaultAsync(u => u.Id == claimsPrincipal.FindFirstValue("uid"));
            }
            else
            {
                appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);
            }

            if (appUser == null)
                return Result<User>.Failure(errorType: ErrorType.NotFound, message: "User not found.");

            return Result<User>.Success(Mappings.FromApplicationUser(appUser));
        }

        public async Task<Result<User>> UpdateUser(User user)
        {

            var appUser =  await _userManager.FindByIdAsync(user.UserId);

            if (appUser == null)
                return Result<User>.Failure(errorType: ErrorType.NotFound, message: "User not found.");

            appUser.DisplayName = user.DisplayName;
            appUser.Bio = user.Bio;

            var updateResult = await _userManager.UpdateAsync(appUser);

            if (!updateResult.Succeeded)
                return Result<User>.Failure(errorType: ErrorType.Failure, message: "Problem updating user.");

            return Result<User>.Success(Mappings.FromApplicationUser(appUser));
        }
    }
}