using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Queries.GetActivitiesList
{
    public class GetActivitiesListQuery : IRequest<List<ActivityListViewModel>>
    {
    }
}