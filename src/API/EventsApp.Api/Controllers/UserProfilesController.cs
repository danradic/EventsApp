using EventsApp.Application.Features.UserProfiles.Commands.UpdateUserProfile;
using EventsApp.Application.Features.UserProfiles.Queries.GetUserProfileDetail;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Controllers
{
    public class UserProfilesController : BaseApiController
    {
        private readonly IMediator _mediator;
        public UserProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserProfile(string id)
        {
            return HandleResult(await _mediator.Send(new GetUserProfileDetailQuery { UserId = id }));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserProfileCommand command)
        {
            return HandleResult(await _mediator.Send(command));
        }
    }
}