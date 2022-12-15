using EventsApp.Application.Features.Activities.Commands.CreateActivity;
using EventsApp.Application.Features.Activities.Commands.DeleteActivity;
using EventsApp.Application.Features.Activities.Commands.UpdateActivity;
using EventsApp.Application.Features.Activities.Queries.GetActivitiesList;
using EventsApp.Application.Features.Activities.Queries.GetActivityDetail;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Controllers
{
    public class ActivitiesController : BaseApiController
    {

        [HttpGet]
        public async Task<IActionResult> GetActivities()
        {
            return HandleResult(await Mediator.Send(new GetActivitiesListQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivity(Guid id)
        {
            return HandleResult(await Mediator.Send(new GetActivityDetailQuery{ Id = id }));
        }

        [HttpPost(Name="AddActivity")]
        public async Task<IActionResult> AddActivity([FromBody] CreateActivityCommand createActivityCommand)
        {
            return HandleResult(await Mediator.Send(createActivityCommand));
        }

        [HttpPut(Name = "UpdateActivity")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateActivity([FromBody] UpdateActivityCommand updateActivityCommand) 
        {
            return HandleResult(await Mediator.Send(updateActivityCommand));
        }

        [HttpDelete("{id}", Name = "DeleteActivity")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleteActivityCommand = new DeleteActivityCommand() { ActivityId = id };
            return HandleResult(await Mediator.Send(deleteActivityCommand));
        }
    }
}