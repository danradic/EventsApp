using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.UpdateActivity
{
    public class UpdateActivityCommand : IRequest<Result<Unit>>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}