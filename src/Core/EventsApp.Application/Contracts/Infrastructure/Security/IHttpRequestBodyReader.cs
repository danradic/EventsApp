namespace EventsApp.Application.Contracts.Infrastructure.Security
{
    public interface IHttpRequestBodyReader
    {
        Task<T> GetRequestBody<T>();
    }
}