using EventsApp.Application.Contracts.Infrastructure.Services.Photos;
using EventsApp.Application.Responses;
using MediatR;

namespace EventsApp.Application.Features.Photos.Commands.CreatePhotoCommand
{
    public class CreatePhotoCommand : IRequest<Result<PhotoViewModel>>
    {
        public IFormFileProxy File { get; set; }
    }
}