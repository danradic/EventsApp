using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
using EventsApp.Application.Responses;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.UpdateActivity
{
    public class UpdateActivityCommandHandler : IRequestHandler<UpdateActivityCommand, Result<Unit>>
    {
       private readonly IRepositoryAsync<Activity> _activityRepository;
        private readonly IMapper _mapper;

        public UpdateActivityCommandHandler(IMapper mapper, IRepositoryAsync<Activity> eventRepository)
        {
            _mapper = mapper;
            _activityRepository = eventRepository;
        }

        public async Task<Result<Unit>> Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
        {
            var result = new Result<Unit>();

            var activityToUpdate = await _activityRepository.GetByIdAsync(request.Id);

            if (activityToUpdate == null)
                return Result<Unit>.Failure(errorType: ErrorType.NotFound, message: $"Activity with id {request.Id} not found.");

            var validator = new UpdateActivityCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errors = _mapper.Map<List<Error>>(validationResult.Errors);
                return Result<Unit>.Failure(errors: errors);
            }

            _mapper.Map(request, activityToUpdate, typeof(UpdateActivityCommand), typeof(Activity));

            await _activityRepository.UpdateAsync(activityToUpdate);

            return Result<Unit>.Success(Unit.Value);
        }
    }
}