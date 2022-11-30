using MediatR;

namespace EventsApp.Application.Features.Activities.Queries.GetActivityDetail
{
    public class GetActivityDetailQuery : IRequest<ActivityDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}