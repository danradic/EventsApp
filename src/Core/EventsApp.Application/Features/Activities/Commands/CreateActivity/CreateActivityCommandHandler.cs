using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Responses;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.CreateActivity
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, Result<ActivityViewModel>>
    {
        private readonly IActivityRepository _activityRepository;
        private readonly IMapper _mapper;
        public CreateActivityCommandHandler(IActivityRepository activityRepository, IMapper mapper)
        {
            _mapper = mapper;
            _activityRepository = activityRepository;
        }

        public async Task<Result<ActivityViewModel>> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateActivityCommandValidator(_activityRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
                return Result<ActivityViewModel>.Failure(errors: validationResult.Errors);

            var activity = _mapper.Map<Activity>(request);

            var addActivityResponse = await _activityRepository.AddAsync(activity);

            var activityDto = _mapper.Map<ActivityViewModel>(addActivityResponse);

            return Result<ActivityViewModel>.Success(activityDto);
        }
    }
}