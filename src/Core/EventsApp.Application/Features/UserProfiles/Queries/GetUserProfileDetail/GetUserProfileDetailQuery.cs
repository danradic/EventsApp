using EventsApp.Application.Models;
using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.UserProfiles.Queries.GetUserProfileDetail
{
    public class GetUserProfileDetailQuery : IRequest<Result<User>>
    {
        public string UserId { get; set; }
    }
}