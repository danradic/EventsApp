using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.DeleteActivity
{
    public class DeleteActivityCommand : IRequest
    {
        public Guid ActivityId { get; set; }
    }
}