using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.DeleteActivity
{
    public class DeleteActivityCommand : IRequest<Result<Unit>>
    {
        public Guid ActivityId { get; set; }
    }
}