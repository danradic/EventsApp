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
        public async Task<ActionResult<List<ActivityListViewModel>>> GetActivities()
        {
            return Ok(await Mediator.Send(new GetActivitiesListQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityDetailViewModel>> GetActivity(Guid id)
        {
            return Ok(await Mediator.Send(new GetActivityDetailQuery{ Id = id }));
        }

        [HttpPost(Name="AddActivity")]
        public async Task<ActionResult<Guid>> AddActivity([FromBody] CreateActivityCommand createActivityCommand)
        {
            var id = await Mediator.Send(createActivityCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateActivity")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateActivity([FromBody] UpdateActivityCommand updateActivityCommand) 
        {
            await Mediator.Send(updateActivityCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteActivity")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteActivityCommand = new DeleteActivityCommand() { ActivityId = id };
            await Mediator.Send(deleteActivityCommand);
            return NoContent();
        }
    }
}