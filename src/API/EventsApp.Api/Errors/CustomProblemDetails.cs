using EventsApp.Application.Errors;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Errors
{
    public class CustomProblemDetails : ProblemDetails
    {
        public CustomProblemDetails()
        {
            Errors = new();
        }
        public List<Error> Errors { get; set; }

    }
}