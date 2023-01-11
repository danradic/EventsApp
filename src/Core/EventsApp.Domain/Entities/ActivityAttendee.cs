namespace EventsApp.Domain.Entities
{
    public class ActivityAttendee
    {
        public Guid ActivityAttendeeId { get; set; }
        public string UserId { get; set; }
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; } 
        public bool IsHost { get; set; }
    }
}