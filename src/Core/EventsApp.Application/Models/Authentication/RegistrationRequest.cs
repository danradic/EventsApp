using System.ComponentModel.DataAnnotations;

namespace EventsApp.Application.Models.Authentication
{
    public class RegistrationRequest
    {
        [Required] 
        public string DisplayName { get; set; }

        [Required]
        public string Bio { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
