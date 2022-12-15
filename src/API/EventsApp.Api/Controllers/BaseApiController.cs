using EventsApp.Api.Errors;
using EventsApp.Application.Errors;
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
            if (result.IsSuccess) return Ok(result.Value);

            var problemDetails = new CustomProblemDetails()
            {
                Title = result.Message,
                Errors = result.Errors
            };

            var firstError = result.Errors[0];
            switch (firstError.ErrorType)
            {
                case ErrorType.Conflict:
                    return Conflict(problemDetails);
                case ErrorType.Validation:
                    return BadRequest(problemDetails);
                case ErrorType.NotFound:
                    return NotFound(problemDetails);
                default:
                    return Problem(statusCode: 500, title: "500 Internal Server Error");
            }
        }
    }
}