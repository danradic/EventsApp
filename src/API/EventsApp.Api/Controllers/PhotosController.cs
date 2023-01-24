using EventsApp.Application.Features.Photos.Commands.CreatePhotoCommand;
using EventsApp.Application.Features.Photos.Commands.DeletePhotoCommand;
using EventsApp.Application.Features.Photos.Commands.SetMainPhotoCommand;
using EventsApp.Infrastructure.Services.Photos;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Api.Controllers
{
    [Authorize]
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

        [HttpPost("{id}/setMain")]
        public async Task<IActionResult> SetMain(string id)
        {
            return HandleResult(await _mediator.Send(new SetMainPhotoCommand { PhotoId = id }));
        }
    }
}