using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Photos.Commands.DeletePhotoCommand
{
    public class DeletePhotoCommand : IRequest<Result<Unit>>
    {
        public string PhotoId { get; set; }
    }
}