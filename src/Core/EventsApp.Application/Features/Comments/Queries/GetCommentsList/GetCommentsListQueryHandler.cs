using AutoMapper;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Comments.Queries.GetCommentsList
{
    public class GetCommentsListQueryHandler : IRequestHandler<GetCommentsListQuery, Result<List<CommentsListDto>>>
    {
        private readonly ICommentsRepository _commentsRepository;
        private readonly IUserAccessor _userAccessor;
        private readonly IPhotoRepository _photoRepository;
        private readonly IMapper _mapper;

        public GetCommentsListQueryHandler(
            ICommentsRepository commentsRepository,
            IUserAccessor userAccessor,
            IPhotoRepository photoRepository,
            IMapper mapper)
        {
            _commentsRepository = commentsRepository;
            _userAccessor = userAccessor;
            _photoRepository = photoRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<CommentsListDto>>> Handle(GetCommentsListQuery request, CancellationToken cancellationToken)
        {
            var comments = await _commentsRepository.GetCommentsByActivityId(request.ActivityId);

            if(comments == null || !comments.Any())
                return Result<List<CommentsListDto>>.Failure(errorType: ErrorType.NotFound, message: "Comments not found.");
            
            var userIdList = comments.Select(c => c.ApplicationUserId).ToList();
            var users = await _userAccessor.GetUsers(userIdList);
            var photos = await _photoRepository.GetMainPhotos(userIdList);

            var commentsDto = _mapper.Map<List<CommentsListDto>>(comments);

            foreach (var comment in commentsDto)
            {
                var user = users.Value.FirstOrDefault(u => u.UserId == comment.ApplicationUserId);
                comment.DisplayName = user.DisplayName;
                comment.UserName = user.UserName;
                var photo = photos.FirstOrDefault(p => p.ApplicationUserId == comment.ApplicationUserId);
                comment.Image = photo.Url;
            }

            return Result<List<CommentsListDto>>.Success(commentsDto);
        }
    }
}