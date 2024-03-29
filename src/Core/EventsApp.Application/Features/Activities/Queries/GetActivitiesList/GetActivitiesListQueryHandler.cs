using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Responses;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Queries.GetActivitiesList
{
    public class GetActivitiesListQueryHandler : IRequestHandler<GetActivitiesListQuery, Result<List<ActivityListViewModel>>>
    {
        private readonly IActivityRepository _activityRepository;
        private readonly IMapper _mapper;

        public GetActivitiesListQueryHandler(IActivityRepository activityRepository, IMapper mapper)
        {
            _mapper = mapper;
            _activityRepository = activityRepository;

        }

        public async Task<Result<List<ActivityListViewModel>>> Handle(GetActivitiesListQuery request, CancellationToken cancellationToken)
        {
            var allActivities =  await _activityRepository.GetActivitiesWithAttendees(includePassedActivites: true);
            var activitiesDto = _mapper.Map<List<ActivityListViewModel>>(allActivities);

            return Result<List<ActivityListViewModel>>.Success(activitiesDto);
        }
    }
}