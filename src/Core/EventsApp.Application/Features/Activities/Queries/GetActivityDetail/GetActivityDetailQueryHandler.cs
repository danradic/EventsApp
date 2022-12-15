using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Responses;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Queries.GetActivityDetail
{
    public class GetActivityDetailQueryHandler : IRequestHandler<GetActivityDetailQuery, Result<ActivityDetailViewModel>>
    {
        private readonly IRepositoryAsync<Activity> _activityRepository;
        private readonly IMapper _mapper;

        public GetActivityDetailQueryHandler(IRepositoryAsync<Activity> activityRepository, IMapper mapper)
        {
            _mapper = mapper;
            _activityRepository = activityRepository;
        }

        public async Task<Result<ActivityDetailViewModel>> Handle(GetActivityDetailQuery request, CancellationToken cancellationToken)
        {
            var result = new Result<ActivityDetailViewModel>();
            
            var activityDetail = await _activityRepository.GetByIdAsync(request.Id);

            if(activityDetail == null) 
            {
                result.Message = $"Activity with id {request.Id} not found";
            }

            var activityDto = _mapper.Map<ActivityDetailViewModel>(activityDetail);
            result.Value = activityDto;

            return result;
        }
    }
}