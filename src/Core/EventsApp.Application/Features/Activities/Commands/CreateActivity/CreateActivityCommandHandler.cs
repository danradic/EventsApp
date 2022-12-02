using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.CreateActivity
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, Guid>
    {
        private readonly IActivityRepository _activityRepository;
        private readonly IMapper _mapper;
        public CreateActivityCommandHandler(IActivityRepository activityRepository, IMapper mapper)
        {
            _mapper = mapper;
            _activityRepository = activityRepository;
        }

        public async Task<Guid> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateActivityCommandValidator(_activityRepository);
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult); 

            var activity = _mapper.Map<Activity>(request);

            var addActivityResponse = await _activityRepository.AddAsync(activity);
            
            return addActivityResponse.Id;
        }
    }
}