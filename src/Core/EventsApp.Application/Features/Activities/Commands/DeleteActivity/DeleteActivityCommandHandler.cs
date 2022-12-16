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
            var activityToDelete = await _activityRepository.GetByIdAsync(request.ActivityId);

            if (activityToDelete == null)
                return Result<Unit>.Failure(errorType: ErrorType.NotFound, message: $"Activity with id {request.ActivityId} not found.");

            await _activityRepository.DeleteAsync(activityToDelete);

            return Result<Unit>.Success(Unit.Value);
        }
    }
}