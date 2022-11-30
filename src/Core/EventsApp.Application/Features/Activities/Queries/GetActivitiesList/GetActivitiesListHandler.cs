using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Queries.GetActivitiesList
{
    public class GetActivitiesListHandler : IRequestHandler<GetActivitiesListQuery, List<ActivityListViewModel>>
    {
        private readonly IRepositoryAsync<Activity> _activityRepository;
        private readonly IMapper _mapper;

        public GetActivitiesListHandler(IRepositoryAsync<Activity> activityRepository, IMapper mapper)
        {
            _mapper = mapper;
            _activityRepository = activityRepository;

        }

        public async Task<List<ActivityListViewModel>> Handle(GetActivitiesListQuery request, CancellationToken cancellationToken)
        {
            var allActivities =  await _activityRepository.ListAllAsync();
            return _mapper.Map<List<ActivityListViewModel>>(allActivities);
        }
    }
}