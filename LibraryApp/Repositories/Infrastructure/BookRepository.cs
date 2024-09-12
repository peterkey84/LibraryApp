using LibraryApp.DAL;
using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Repositories.Infrastructure
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {

        private readonly LibraryDbContext _dbContext;

        public BookRepository(LibraryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Book>> GetAvailabilityBooks()
        {

            return  await _dbContext.Books.Include(b => b.bookCopies)
                .Where(a => a.bookCopies.Sum (bc=>bc.Quantity) > 0)
                .ToListAsync();

        }
    }
}
