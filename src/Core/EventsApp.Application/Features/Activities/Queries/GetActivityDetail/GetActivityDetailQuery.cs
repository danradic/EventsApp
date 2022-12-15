using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Activities.Queries.GetActivityDetail
{
    public class GetActivityDetailQuery : IRequest<Result<ActivityDetailViewModel>>
    {
        public Guid Id { get; set; }
    }
}