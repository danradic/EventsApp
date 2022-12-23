using EventsApp.Application.Errors;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Errors
{
    public class CustomProblemDetails : ProblemDetails
    {
        public List<Error> Errors { get; set; }

        public CustomProblemDetails()
        {
            Errors = new();
        }
    }
}