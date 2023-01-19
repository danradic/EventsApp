using EventsApp.Application.Models;
using EventsApp.Identity.Models;

namespace EventsApp.Identity.Profiles
{
    public class Mappings
    {
        public static User FromApplicationUser(ApplicationUser appUser)
        {
            return new User 
            {
                UserId = appUser.Id,
                DisplayName = appUser.DisplayName,
                Email = appUser.Email,
                Image = null,
                UserName = appUser.UserName,
                Bio = appUser.Bio
            };
        }  
    }
}