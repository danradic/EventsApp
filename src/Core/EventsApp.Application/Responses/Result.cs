namespace EventsApp.Application.Responses
{
    public class Result<T>
    {
        public Result()
        {
            IsSuccess = true;
        }
        
        public Result(string? message = null)
        {
            IsSuccess = true;
            Message = message;
        }

        public Result(string message, bool success)
        {
            IsSuccess = success;
            Message = message;
        }

        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public List<string>? ValidationErrors { get; set; }
        public T? Value { get; set; }
    }
}