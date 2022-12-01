using EventsApp.Application.Features.Activities.Commands.CreateActivity;
using EventsApp.Application.Features.Activities.Queries.GetActivitiesList;
using EventsApp.Application.Features.Activities.Queries.GetActivityDetail;
using EventsApp.Domain.Entities;
using MediatR;
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
        public async Task<ActionResult<List<ActivityListViewModel>>> GetActivities()
        {
            return Ok(await _mediator.Send(new GetActivitiesListQuery()));
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityDetailViewModel>> GetActivity(Guid id)
        {
            return Ok(await _mediator.Send(new GetActivityDetailQuery{ Id = id }));
        }

        [HttpPost(Name="AddActivity")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateActivityCommand createActivityCommand)
        {
            var id = await _mediator.Send(createActivityCommand);

            return Ok(id);
        }
    }
}