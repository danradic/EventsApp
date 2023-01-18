using EventsApp.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EventsApp.Persistence.Repositories
{
    public class BaseRepository<T> : IRepositoryAsync<T> where T : class
    {
        protected readonly EventsAppDbContext _dbContext;
        public BaseRepository(EventsAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(params object[] id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync();
        }
    }
}