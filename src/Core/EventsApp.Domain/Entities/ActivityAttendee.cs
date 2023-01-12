namespace EventsApp.Domain.Entities
{
    public class ActivityAttendee
    {
        public Guid ActivityAttendeeId { get; set; }
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; } 
        public bool IsHost { get; set; }
    }
}