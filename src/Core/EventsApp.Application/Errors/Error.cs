using FluentValidation.Results;

namespace EventsApp.Application.Errors
{
    public class Error : ValidationFailure
    {
        public ErrorType ErrorType { get; set; }
    }
}