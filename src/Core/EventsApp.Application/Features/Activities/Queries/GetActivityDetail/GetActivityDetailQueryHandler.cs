using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Queries.GetActivityDetail
{
    public class GetActivityDetailQueryHandler : IRequestHandler<GetActivityDetailQuery, ActivityDetailViewModel>
    {
        private readonly IRepositoryAsync<Activity> _activityRepository;
        private readonly IMapper _mapper;

        public GetActivityDetailQueryHandler(IRepositoryAsync<Activity> activityRepository, IMapper mapper)
        {
            _mapper = mapper;
            _activityRepository = activityRepository;
        }

        public async Task<ActivityDetailViewModel> Handle(GetActivityDetailQuery request, CancellationToken cancellationToken)
        {
            var activityDetail = await _activityRepository.GetByIdAsync(request.Id);

            return _mapper.Map<ActivityDetailViewModel>(activityDetail);
        }
    }
}