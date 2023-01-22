using AutoMapper;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Models;
using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.UserProfiles.Commands.UpdateUserProfile
{
    public class UpdateUserProfileCommandHandler : IRequestHandler<UpdateUserProfileCommand, Result<User>>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly IMapper _mapper;
        public UpdateUserProfileCommandHandler(IUserAccessor userAccessor, IMapper mapper)
        {
            _mapper = mapper;
            _userAccessor = userAccessor;
        }

        public async Task<Result<User>> Handle(UpdateUserProfileCommand request, CancellationToken cancellationToken)
        {
            var userUpdateResult = await _userAccessor.UpdateUser(_mapper.Map<User>(request));

            if (!userUpdateResult.IsSuccess)
                return Result<User>.Failure(errorType: userUpdateResult.ErrorType, message: userUpdateResult.Message);

            return Result<User>.Success(userUpdateResult.Value);
        }
    }
}