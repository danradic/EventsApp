using EventsApp.Domain.Entities;

namespace EventsApp.Application.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}