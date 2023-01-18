using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
using EventsApp.Application.Models;
using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.UserProfiles.Queries.GetUserProfileDetail
{
    public class GetUserProfileDetailQueryHandler : IRequestHandler<GetUserProfileDetailQuery, Result<User>>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly IPhotoRepository _photoRepository;
        public GetUserProfileDetailQueryHandler(
            IUserAccessor userAccessor,
             IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
            _userAccessor = userAccessor;
        }

        public async Task<Result<User>> Handle(GetUserProfileDetailQuery request, CancellationToken cancellationToken)
        {
            var currentUserResult = _userAccessor.GetCurrentUser();

            if(!currentUserResult.Result.IsSuccess)
                return Result<User>.Failure(errorType: currentUserResult.Result.ErrorType, message: currentUserResult.Result.Message);

            var currentUser = currentUserResult.Result.Value;
            currentUser.Photos = await _photoRepository.GetPhotosByUserId(currentUser.UserId);

            return Result<User>.Success(currentUser);
        }
    }
}