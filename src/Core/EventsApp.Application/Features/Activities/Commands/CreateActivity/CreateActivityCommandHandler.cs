using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
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
            var result = new Result<ActivityViewModel>();

            var validator = new CreateActivityCommandValidator(_activityRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                result.IsSuccess = false;
                result.Message = "One or more validation errors occured";
                result.Errors = new();

                foreach (var validationError in validationResult.Errors)
                {
                    Error error = new()
                    {
                        ErrorMessage = validationError.ErrorMessage,
                        ErrorCode = validationError.ErrorCode,
                        ErrorType = validationError.ErrorCode.Equals("EventNameAndDateNotUnique") ? ErrorType.Conflict : ErrorType.Validation
                    };
                    result.Errors.Add(error);
                }

                return result;
            }

            var activity = _mapper.Map<Activity>(request);
            var addActivityResponse = await _activityRepository.AddAsync(activity);

            if (addActivityResponse == null)
            {
                result.IsSuccess = false;
                result.Message = "An error has occored.";
                result.Errors = new()
                {
                    new Error
                    {
                        ErrorMessage = "Failed to create activity.",
                        ErrorType = ErrorType.Failure
                    }
                };
                
                return result;
            }

            var activityDto = _mapper.Map<ActivityViewModel>(addActivityResponse);
            result.Value = activityDto;

            return result;
        }
    }
}