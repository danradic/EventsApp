using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Comments.Queries.GetCommentsList
{
    public class GetCommentsListQuery : IRequest<Result<List<CommentsListDto>>>
    {
        public Guid ActivityId { get; set; }
    }
}