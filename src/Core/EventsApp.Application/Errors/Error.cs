namespace EventsApp.Application.Errors
{
    public class Error
    {
        public string ErrorMessage { get; set; }
        public string ErrorCode { get; set; }
        public ErrorType ErrorType { get; set; }
    }
}