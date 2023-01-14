using System.Text;
using EventsApp.Application.Contracts.Infrastructure.Security;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace EventsApp.Infrastructure.Security
{
    public class HttpRequestBodyReader : IHttpRequestBodyReader
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HttpRequestBodyReader(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<T> GetRequestBody<T>()
        {
            string requestBody = "";
            HttpRequest req = _httpContextAccessor.HttpContext.Request;
            req.EnableBuffering();
            if (_httpContextAccessor.HttpContext.Request.Body.CanSeek)
            {
                _httpContextAccessor.HttpContext.Request.Body.Seek(0, SeekOrigin.Begin);
                using StreamReader reader = new(_httpContextAccessor.HttpContext.Request.Body, Encoding.UTF8, false, 1024, true);
                requestBody = await reader.ReadToEndAsync();
            }

            req.Body.Position = 0;
            var bodyObj = JsonConvert.DeserializeObject<T>(requestBody);
            return bodyObj;
        }
    }
}