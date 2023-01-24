using EventsApp.Application.Features.Comments.Commands.CreateComment;
using EventsApp.Application.Features.Comments.Queries.GetCommentsList;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace EventsApp.Api.SignalR
{
    public class ChatHub : Hub
    {
        private readonly IMediator _mediator;
        public ChatHub(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendComment(CreateCommentCommand command)
        {
            var commentResult = await _mediator.Send(command);

            if(!commentResult.IsSuccess) return;

            await Clients.Group(command.ActivityId.ToString())
                .SendAsync("ReceiveComment", commentResult.Value);
        }

        public override async Task OnConnectedAsync()
        {
            var httpContext = Context.GetHttpContext();
            var activityId = httpContext.Request.Query["activityId"];
            await Groups.AddToGroupAsync(Context.ConnectionId, activityId);
            var result = await _mediator.Send(new GetCommentsListQuery { ActivityId = Guid.Parse(activityId) });
            await Clients.Caller.SendAsync("LoadComments", result.Value);
        }
    }
}