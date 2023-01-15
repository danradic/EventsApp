using AutoMapper;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
using EventsApp.Application.Responses;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Activities.Commands.CreateActivity
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, Result<ActivityViewModel>>
    {
        private readonly IActivityRepository _activityRepository;
        private readonly IMapper _mapper;
        private readonly IUserAccessor _userAccessor;
        public CreateActivityCommandHandler(IActivityRepository activityRepository, IMapper mapper, IUserAccessor userAccessor)
        {
            _userAccessor = userAccessor;
            _mapper = mapper;
            _activityRepository = activityRepository;
        }

        public async Task<Result<ActivityViewModel>> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateActivityCommandValidator(_activityRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                var errors = _mapper.Map<List<Error>>(validationResult.Errors);
                return Result<ActivityViewModel>.Failure(errors: errors);
            }

            var currentUserResult = _userAccessor.GetCurrentUser();

            if (!currentUserResult.Result.IsSuccess)
                return Result<ActivityViewModel>.Failure(errorType: currentUserResult.Result.ErrorType, message: currentUserResult.Result.Message);

            var currentUser = currentUserResult.Result.Value;

            var activity = _mapper.Map<Activity>(request);

            activity.Attendees = new List<ActivityAttendee>()
            {
                new ActivityAttendee
                {
                    UserId = currentUser.Id,
                    UserName = currentUser.UserName,
                    DisplayName = currentUser.DisplayName,
                    Email = currentUser.Email,
                    Bio = currentUser.Bio,
                    Image = currentUser.Image,
                    Activity = activity,
                    IsHost = true
                }
            };

            var isActivityCreated = await _activityRepository.AddAsync(activity) > 0;

            return isActivityCreated ? 
                Result<ActivityViewModel>.Success(_mapper.Map<ActivityViewModel>(activity)) : 
                Result<ActivityViewModel>.Failure(errorType: ErrorType.Failure, message: "Problem creating activity.");
        }
    }
}