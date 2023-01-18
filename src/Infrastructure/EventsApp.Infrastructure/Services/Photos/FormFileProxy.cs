using EventsApp.Application.Contracts.Infrastructure.Services.Photos;
using Microsoft.AspNetCore.Http;

namespace EventsApp.Infrastructure.Services.Photos
{
    public class FormFileProxy : IFormFileProxy
    {
        private readonly IFormFile file;
        public FormFileProxy(IFormFile file)
        {
            this.file = file ?? throw new ArgumentNullException(nameof(file));
        }

        public string Name => file.Name;
        public string FileName => file.FileName;
        public string ContentType => file.ContentType;
        public long Length => file.Length;

        public Stream OpenReadStream()
        {
            return file.OpenReadStream();
        }
    }
}