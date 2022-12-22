using Microsoft.AspNetCore.Identity;

namespace EventsApp.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Bio { get; set; }
    }
}