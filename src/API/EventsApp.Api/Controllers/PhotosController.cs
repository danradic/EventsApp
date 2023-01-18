using EventsApp.Api.Services.Photos;
using EventsApp.Application.Features.Photos.Commands.CreatePhotoCommand;
using EventsApp.Application.Features.Photos.Commands.DeletePhotoCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Controllers
{
    public class PhotosController : BaseApiController
    {
        private readonly IMediator _mediator;

        public PhotosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] IFormFile file)
        {
            CreatePhotoCommand command = new() { File = new FormFileProxy(file) };
            return HandleResult(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            return HandleResult(await _mediator.Send(new DeletePhotoCommand { PhotoId = id }));
        }
    }
}