using LibraryApp.DAL;
using LibraryApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Repositories.Infrastructure
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly LibraryDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            if (id == 0)
            {
                return null;
            }

            var entity = await _dbSet.FindAsync(id);

            if (entity == null)
            {
                return null;
            }

            return entity;
        }


        public async Task AddAsync(T entity)
        {
            if (entity != null)
            {
                await _dbSet.AddAsync(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity != null)
            {
                _dbSet.Attach(entity);
                _dbContext.Entry(entity).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }

        }

        public async Task DeleteAsync(T entity)
        {
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }

        }

    }
}
