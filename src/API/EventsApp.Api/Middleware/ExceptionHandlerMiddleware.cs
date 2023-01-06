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
        private readonly ILogger<ExceptionHandlerMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public ExceptionHandlerMiddleware(
            RequestDelegate next, 
            ILogger<ExceptionHandlerMiddleware> logger, 
            IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;            
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                if (!context.Response.HasStarted)
                {
                    await _next(context);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                await ConvertException(context, ex);
            }
        }

        private Task ConvertException(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var problemDetails = new CustomProblemDetails {
                Status = context.Response.StatusCode,
                Title = "An unexpected error occured.",
                Detail = "Internal Server Error."
            };

            if(_env.IsDevelopment())
            {
                problemDetails.Errors = new() 
                {
                    new Error 
                    { 
                        ErrorMessage = $"{exception.Message}, StackTrace: {exception.StackTrace?.ToString()}",
                        ErrorType = ErrorType.Unexpected
                    }
                };
            }

            var result = JsonConvert.SerializeObject(problemDetails);

            return context.Response.WriteAsync(result);
        }
    }
}