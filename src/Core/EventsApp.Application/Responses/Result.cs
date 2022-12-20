using EventsApp.Application.Errors;
using FluentValidation.Results;

namespace EventsApp.Application.Responses
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public List<ValidationFailure>? Errors { get; set; }
        public ErrorType ErrorType { get; set; }

        public T? Value { get; set; }

        public static Result<T> Success(T value, string? message = null) =>
            new Result<T> { IsSuccess = true, Value = value, Message = message };

        public static Result<T> Failure(ErrorType errorType = ErrorType.Validation, List<ValidationFailure>? errors = null, string? message = null) =>
            new Result<T>
            {
                IsSuccess = false,
                ErrorType = errorType,
                Message = message ??= ErrorMessageBy(errorType),
                Errors = errors
            };

        public static string ErrorMessageBy(ErrorType errorType) =>
            errorType switch
            {
                ErrorType.Conflict => "409 Conflict.",
                ErrorType.Validation => "One or more validation errors occurred.",
                ErrorType.NotFound => "404 Not Found.",
                _ => "500 Internal Server Error."
            };
    }
}