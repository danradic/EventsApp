using System.ComponentModel.DataAnnotations;

namespace EventsApp.Application.Models.Authentication
{
    public class RegistrationRequest
    {
        [Required]
        public string DisplayName { get; set; }

        public string Bio { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$", ErrorMessage = "Password must contain at least one uppercase, lowercase, digit and special character.")]
        public string Password { get; set; }
    }
}
