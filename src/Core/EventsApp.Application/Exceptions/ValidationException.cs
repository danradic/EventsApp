using FluentValidation.Results;

namespace EventsApp.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> ValidationErrors {get; set;}

        public ValidationException(ValidationResult validationResult)
        {
            ValidationErrors = new();

            foreach (var error in validationResult.Errors)
            {
                ValidationErrors.Add(error.ErrorMessage);
            }

        }
    }
}