using System.Security.Claims;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Domain.Entities;
using EventsApp.Persistence;
using Microsoft.AspNetCore.Authorization;

namespace EventsApp.Infrastructure.Security
{
    public class IsHostRequirement : IAuthorizationRequirement
    {
    }

    public class IsHostRequirementHandler : AuthorizationHandler<IsHostRequirement>
    {
        private readonly EventsAppDbContext _dbContext;
        private readonly IHttpRequestBodyReader _httpRequestBodyReader;

        public IsHostRequirementHandler(
            EventsAppDbContext dbContext,
            IHttpRequestBodyReader httpRequestBodyReader)
        {
            _dbContext = dbContext;
            _httpRequestBodyReader = httpRequestBodyReader;
        }

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            IsHostRequirement requirement)
        {
            var userId = context.User.FindFirstValue("uid");

            if(userId == null) return;

            var activity = await _httpRequestBodyReader.GetRequestBody<Activity>();

            if (activity == null) return;

            var attendee = _dbContext.ActivityAttendees
                .Where(aa => aa.UserId == userId && aa.ActivityId == activity.Id)
                .FirstOrDefault();

            if (attendee == null) return;

            if (attendee.IsHost) context.Succeed(requirement);

            return;
        }

    }
}