using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Exceptions;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.UpdateActivity
{
    public class UpdateActivityCommandHandler : IRequestHandler<UpdateActivityCommand>
    {
       private readonly IRepositoryAsync<Activity> _activityRepository;
        private readonly IMapper _mapper;

        public UpdateActivityCommandHandler(IMapper mapper, IRepositoryAsync<Activity> eventRepository)
        {
            _mapper = mapper;
            _activityRepository = eventRepository;
        }

        public async Task<Unit> Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
        {
            var activityToUpdate = await _activityRepository.GetByIdAsync(request.Id);

            if (activityToUpdate == null) 
                throw new NotFoundException(nameof(Activity), request.Id);

            var validator = new UpdateActivityCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0) 
                throw new ValidationException(validationResult);

            _mapper.Map(request, activityToUpdate, typeof(UpdateActivityCommand), typeof(Activity));

            await _activityRepository.UpdateAsync(activityToUpdate);

            return Unit.Value;
        }
    }
}