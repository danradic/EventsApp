using EventsApp.Application.Errors;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Errors
{
    public class CustomProblemDetails : ProblemDetails
    {
        public List<ValidationFailure> Errors { get; set; }

        public CustomProblemDetails()
        {
            Errors = new();
        }
    }
}