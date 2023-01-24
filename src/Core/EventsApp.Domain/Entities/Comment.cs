namespace EventsApp.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string ApplicationUserId { get; set; }
        public Activity Activity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}