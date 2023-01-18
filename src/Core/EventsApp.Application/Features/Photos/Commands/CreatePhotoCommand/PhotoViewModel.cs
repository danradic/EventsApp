namespace EventsApp.Application.Features.Photos.Commands.CreatePhotoCommand
{
    public class PhotoViewModel
    {
        public string Id { get; set; }
        public string ApplicationUserId { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
    }
}