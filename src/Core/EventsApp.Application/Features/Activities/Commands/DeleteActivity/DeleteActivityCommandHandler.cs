using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
using EventsApp.Application.Exceptions;
using EventsApp.Application.Responses;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.DeleteActivity
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteActivityCommand, Result<Unit>>
    {
        private readonly IRepositoryAsync<Activity> _activityRepository;
        private readonly IMapper _mapper;
        
        public DeleteEventCommandHandler(IMapper mapper, IRepositoryAsync<Activity> eventRepository)
        {
            _mapper = mapper;
            _activityRepository = eventRepository;
        }

        public async Task<Result<Unit>> Handle(DeleteActivityCommand request, CancellationToken cancellationToken)
        {
            var result = new Result<Unit>();

            var activityToDelete = await _activityRepository.GetByIdAsync(request.ActivityId);

            if (activityToDelete == null)
            {
                result.IsSuccess = false;
                result.Message = "404 Not Found";
                result.Errors = new() 
                {
                    new Error
                    {
                        ErrorMessage = $"Activity with id {request.ActivityId} not found.",
                        ErrorType = ErrorType.NotFound
                    }
                };

                return result;
            }

            await _activityRepository.DeleteAsync(activityToDelete);

            return result;
        }
    }
}