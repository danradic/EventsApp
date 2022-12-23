using FluentValidation;

namespace EventsApp.Application.Features.Register
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(x => x.DisplayName)
                .NotEmpty().WithMessage("Display Name is required.");
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("Username is required.");
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email address is required.")
                .EmailAddress().WithMessage("A valid email address is required.");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.");
        }
    }
}