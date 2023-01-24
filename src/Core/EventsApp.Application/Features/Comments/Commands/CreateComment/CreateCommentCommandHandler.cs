using AutoMapper;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Contracts.Persistence;
using EventsApp.Application.Errors;
using EventsApp.Application.Responses;
using EventsApp.Domain.Entities;
using MediatR;

namespace EventsApp.Application.Features.Comments.Commands.CreateComment
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Result<CommentDto>>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly IActivityRepository _activityRepository;
        private readonly IPhotoRepository _photoRepository;
        private readonly IMapper _mapper;

        public CreateCommentCommandHandler(
            IUserAccessor userAccessor,
            IActivityRepository activityRepository,
            IPhotoRepository photoRepository,
            IMapper mapper)
        {
            _activityRepository = activityRepository;
            _photoRepository = photoRepository;
            _mapper = mapper;
            _userAccessor = userAccessor;
        }

        public async Task<Result<CommentDto>> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var activity = await _activityRepository.GetByIdAsync(request.ActivityId);

            if(activity == null) return null;
            
            var currentUserResult = await _userAccessor.GetUser();

            if(!currentUserResult.IsSuccess)
                return Result<CommentDto>.Failure(errorType: currentUserResult.ErrorType, message: currentUserResult.Message);

            var curentUser = currentUserResult.Value;
            var currentUserMainPhoto = await _photoRepository.GetMainPhoto(curentUser.UserId);
            curentUser.Image = currentUserMainPhoto.Url;

            Comment comment = new()
            {
                ApplicationUserId = curentUser.UserId,
                Activity = activity,
                Body = request.Body
            };

            activity.Comments.Add(comment);

            var isCommentCreated = await _activityRepository.UpdateAsync(activity) > 0;

            if (!isCommentCreated)
                return Result<CommentDto>.Failure(errorType: ErrorType.Failure, message: "Failed to create comment.");

            var commentDto = _mapper.Map<CommentDto>(comment);
            commentDto.DisplayName = curentUser.DisplayName;
            commentDto.UserName = curentUser.UserName;
            commentDto.Image = curentUser.Image;

            return Result<CommentDto>.Success(commentDto);
        }
    }
}