using EventsApp.Application.Errors;

namespace EventsApp.Application.Responses
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<Error> Errors { get; set; }
        public ErrorType ErrorType { get; set; }

        public T Value { get; set; }

        public static Result<T> Success(T value, string message = null) =>
            new Result<T> { IsSuccess = true, Value = value, Message = message };

        public static Result<T> Failure(ErrorType errorType = ErrorType.Validation, List<Error> errors = null, string message = null) =>
            new Result<T>
            {
                IsSuccess = false,
                ErrorType = errorType,
                Message = message ??= ErrorMessageBy(errorType),
                Errors = errors ??= GetErrorList(message)
            };

        public static string ErrorMessageBy(ErrorType errorType) =>
            errorType switch
            {
                ErrorType.Conflict => "409 Conflict.",
                ErrorType.Validation => "One or more validation errors occurred.",
                ErrorType.NotFound => "404 Not Found.",
                ErrorType.Unauthorized => "401 Not Authorized.",
                _ => "500 Internal Server Error."
            };

        public static List<Error> GetErrorList(string message)
        {
            List<Error> errors = new(); 

            if(string.IsNullOrEmpty(message)) return errors;

            errors.Add(new Error { ErrorMessage = message });

            return errors;
        }
    }
}