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

        public static List<User> FromApplicationUsers(List<ApplicationUser> appUsers)
        {
            List<User> users = new();

            foreach (var appUser in appUsers)
            {
                User user = new();
                user.UserId = appUser.Id;
                user.DisplayName = appUser.DisplayName;
                user.Email = appUser.Email;
                user.Image = null;
                user.UserName = appUser.UserName;
                user.Bio = appUser.Bio;
                users.Add(user);
            }
            return users;
        }  
    }
}