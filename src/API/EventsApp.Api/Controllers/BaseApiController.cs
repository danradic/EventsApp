using EventsApp.Api.Errors;
using EventsApp.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ?? HttpContext.RequestServices.GetService<IMediator>();

        protected IActionResult HandleResult<T>(Result<T> result)
        {
            if(result.IsSuccess && result.Value != null)
                return Ok(result.Value);
                
            var problemDetails = new CustomProblemDetails() 
            {
                Title = result.Message,
                Errors = result.ValidationErrors
            };
            
            if(result.IsSuccess && result.Value == null)
                return NotFound(problemDetails);
                
            return BadRequest(problemDetails);
        }
    }
}