using AutoMapper;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
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
            var activityDetail = await _activityRepository.GetByIdAsync(request.Id);

            if(activityDetail == null) 
                return Result<ActivityDetailViewModel>.Failure(errorType: ErrorType.NotFound, message: $"Activity with id {request.Id} not found.");

            var activityDto = _mapper.Map<ActivityDetailViewModel>(activityDetail);

            return Result<ActivityDetailViewModel>.Success(activityDto);
        }
    }
}