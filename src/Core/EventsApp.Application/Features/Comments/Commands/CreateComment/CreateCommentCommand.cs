using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Comments.Commands.CreateComment
{
    public class CreateCommentCommand : IRequest<Result<CommentDto>>
    {
        public string Body { get; set; }
        public Guid ActivityId { get; set; }
    }
}