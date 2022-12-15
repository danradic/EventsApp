using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
using EventsApp.Application.Exceptions;
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
            {
                result.IsSuccess = false;
                result.Message = "404 Not Found";
                result.Errors = new() 
                {
                    new Error
                    {
                        ErrorMessage = $"Activity with id {request.Id} not found.",
                        ErrorType = ErrorType.NotFound
                    }
                };

                return result;
            }

            var validator = new UpdateActivityCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

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
                        ErrorType = ErrorType.Validation
                    };

                    result.Errors.Add(error);
                }

                return result;
            }
            _mapper.Map(request, activityToUpdate, typeof(UpdateActivityCommand), typeof(Activity));

            await _activityRepository.UpdateAsync(activityToUpdate);

            return result;
        }
    }
}