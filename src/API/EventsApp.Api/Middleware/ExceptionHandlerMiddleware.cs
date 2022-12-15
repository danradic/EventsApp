using System.Net;
using EventsApp.Api.Errors;
using EventsApp.Application.Errors;
using EventsApp.Application.Exceptions;
using Newtonsoft.Json;

namespace EventsApp.Api.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await ConvertException(context, ex);
            }
        }

        private Task ConvertException(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var problemDetails = new CustomProblemDetails {
                Status = (int)HttpStatusCode.InternalServerError,
                Title = "An unexpected error occured.",
                Detail = "500 Internal Server Error.",
                Errors = new List<Error>() 
                {
                    new Error 
                    { 
                        ErrorMessage = exception.Message,
                        ErrorType = ErrorType.Unexpected
                    }
                } 
            };

            var result = JsonConvert.SerializeObject(problemDetails);

            return context.Response.WriteAsync(result);
        }
    }
}