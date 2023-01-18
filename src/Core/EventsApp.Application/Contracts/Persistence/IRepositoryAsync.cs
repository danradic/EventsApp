namespace EventsApp.Application.Contracts.Persistence
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<T> GetByIdAsync(params object[] id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<int> AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
    }
}