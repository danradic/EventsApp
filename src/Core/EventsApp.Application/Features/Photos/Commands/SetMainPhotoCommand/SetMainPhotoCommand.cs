using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Photos.Commands.SetMainPhotoCommand
{
    public class SetMainPhotoCommand : IRequest<Result<Unit>>
    {
        public string PhotoId { get; set; }
    }
}