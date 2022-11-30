using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.CreateActivity
{
    public class CreateActivityCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}