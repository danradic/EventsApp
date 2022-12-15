using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Responses;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Queries.GetActivitiesList
{
    public class GetActivitiesListQueryHandler : IRequestHandler<GetActivitiesListQuery, Result<List<ActivityListViewModel>>>
    {
        private readonly IRepositoryAsync<Activity> _activityRepository;
        private readonly IMapper _mapper;

        public GetActivitiesListQueryHandler(IRepositoryAsync<Activity> activityRepository, IMapper mapper)
        {
            _mapper = mapper;
            _activityRepository = activityRepository;

        }

        public async Task<Result<List<ActivityListViewModel>>> Handle(GetActivitiesListQuery request, CancellationToken cancellationToken)
        {
            var result = new Result<List<ActivityListViewModel>>();

            var allActivities =  await _activityRepository.ListAllAsync();
            var activitiesDto = _mapper.Map<List<ActivityListViewModel>>(allActivities);

            result.Value = activitiesDto;

            return result;
        }
    }
}