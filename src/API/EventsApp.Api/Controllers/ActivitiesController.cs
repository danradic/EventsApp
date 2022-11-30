using EventsApp.Application.Features.Activities.Queries.GetActivitiesList;
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
            return await _mediator.Send(new GetActivitiesListQuery());
            
        }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<Activity>> GetActivity(Guid id)
        // {
        //     return await _context.Activities.FindAsync(id);
        // }
    }
}