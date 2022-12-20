using EventsApp.Application.Contracts.Persistence;
using FluentValidation;

namespace EventsApp.Application.Features.Activities.Commands.CreateActivity
{
    public class CreateActivityCommandValidator : AbstractValidator<CreateActivityCommand>
    {
        private readonly IActivityRepository _activityRepository;
        public CreateActivityCommandValidator(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Date)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(DateTime.Now);

            RuleFor(p => p.City)
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(e => e)
                .MustAsync(IsEventNameAndDateUnique)
                .WithMessage("An event with the same name and date aleady exists.")
                .WithErrorCode("EventNameAndDateNotUnique");

        }

        private async Task<bool> IsEventNameAndDateUnique(CreateActivityCommand e, CancellationToken token)
        {
            return !(await _activityRepository.IsActivityTitleAndDateUnique(e.Title, e.Date));
        }
    }
}