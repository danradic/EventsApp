namespace EventsApp.Application.Contracts.Infrastructure.Services.Photos
{
    public interface IFormFileProxy
    {
        string Name { get; }
        string FileName { get; }
        string ContentType { get; }
        long Length { get; }
        Stream OpenReadStream();
    }
}