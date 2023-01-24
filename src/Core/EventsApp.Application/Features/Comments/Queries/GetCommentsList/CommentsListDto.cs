namespace EventsApp.Application.Features.Comments.Queries.GetCommentsList
{
    public class CommentsListDto
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string ApplicationUserId { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}