using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Activities.Queries.GetActivitiesList
{
    public class GetActivitiesListQuery : IRequest<Result<List<ActivityListViewModel>>>
    {
    }
}