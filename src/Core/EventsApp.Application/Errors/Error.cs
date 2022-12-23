namespace EventsApp.Application.Errors
{
    public class Error
    {
        public ErrorType ErrorType { get; set; }
        public string PropertyName { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}