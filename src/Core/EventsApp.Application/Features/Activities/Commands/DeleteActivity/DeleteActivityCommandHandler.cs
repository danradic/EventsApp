using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Exceptions;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.DeleteActivity
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteActivityCommand>
    {
        private readonly IRepositoryAsync<Activity> _activityRepository;
        private readonly IMapper _mapper;
        
        public DeleteEventCommandHandler(IMapper mapper, IRepositoryAsync<Activity> eventRepository)
        {
            _mapper = mapper;
            _activityRepository = eventRepository;
        }

        public async Task<Unit> Handle(DeleteActivityCommand request, CancellationToken cancellationToken)
        {
            var activityToDelete = await _activityRepository.GetByIdAsync(request.ActivityId);

            if (activityToDelete == null) 
                throw new NotFoundException(nameof(Activity), request.ActivityId);

            await _activityRepository.DeleteAsync(activityToDelete);

            return Unit.Value;
        }
    }
}