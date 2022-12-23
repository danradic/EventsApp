using EventsApp.Api.Errors;
using EventsApp.Application.Errors;
using EventsApp.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        protected IActionResult HandleResult<T>(Result<T> result)
        {
            if (result.IsSuccess) return Ok(result.Value);

            var problemDetails = new CustomProblemDetails()
            {
                Title = result.Message
            };

            if(result.Errors?.Count() > 0)
            {
                problemDetails.Errors = result.Errors;
            }

            switch (result.ErrorType)
            {
                case ErrorType.Conflict:
                    return Conflict(problemDetails);
                case ErrorType.Validation:
                    return BadRequest(problemDetails);
                case ErrorType.NotFound:
                    return NotFound(problemDetails);
                case ErrorType.Unauthorized:
                    return Unauthorized(problemDetails);
                default:
                    return Problem(statusCode: 500, title: "500 Internal Server Error");
            }
        }
    }
}