using EventsApp.Application.Features.Activities.Commands.CreateActivity;
using EventsApp.Application.Features.Activities.Commands.DeleteActivity;
using EventsApp.Application.Features.Activities.Commands.UpdateActivity;
using EventsApp.Application.Features.Activities.Queries.GetActivitiesList;
using EventsApp.Application.Features.Activities.Queries.GetActivityDetail;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly IMediator _mediator;

        public ActivitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetActivities()
        {
            return HandleResult(await _mediator.Send(new GetActivitiesListQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivity(Guid id)
        {
            return HandleResult(await _mediator.Send(new GetActivityDetailQuery{ Id = id }));
        }

        [HttpPost(Name="AddActivity")]
        public async Task<IActionResult> AddActivity([FromBody] CreateActivityCommand createActivityCommand)
        {
            return HandleResult(await _mediator.Send(createActivityCommand));
        }

        [Authorize(Policy = "IsActivityHost")]
        [HttpPut(Name = "UpdateActivity")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateActivity([FromBody] UpdateActivityCommand updateActivityCommand) 
        {
            return HandleResult(await _mediator.Send(updateActivityCommand));
        }

        [Authorize(Policy = "IsActivityHost")]
        [HttpDelete("{id}", Name = "DeleteActivity")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleteActivityCommand = new DeleteActivityCommand() { ActivityId = id };
            return HandleResult(await _mediator.Send(deleteActivityCommand));
        }
    }
}