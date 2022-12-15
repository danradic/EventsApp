using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Errors
{
    public class CustomProblemDetails : ProblemDetails
    {
        public CustomProblemDetails()
        {
            Errors = new();
        }
        public List<string> Errors { get; set; }

    }
}