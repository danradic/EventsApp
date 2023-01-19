using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Contracts.Persistence;
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
            var userResult = _userAccessor.GetUser(request.UserId);

            if(!userResult.Result.IsSuccess)
                return Result<User>.Failure(errorType: userResult.Result.ErrorType, message: userResult.Result.Message);

            var user = userResult.Result.Value;
            user.Photos = await _photoRepository.GetPhotosByUserId(user.UserId);

            if(user.Photos.Any(p => p.IsMain))
                user.Image = user.Photos.FirstOrDefault(p => p.IsMain).Url;

            return Result<User>.Success(user);
        }
    }
}