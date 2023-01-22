using EventsApp.Application.Models;
using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.UserProfiles.Commands.UpdateUserProfile
{
    public class UpdateUserProfileCommand : IRequest<Result<User>>
    {
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string Bio { get; set; }
    }
}