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

            return  await _dbContext.Books
                .Include(a=>a.Author)
                .Include(b => b.bookCopies)
                .Where(a => a.bookCopies.Sum (bc=>bc.Quantity) > 0)
                .ToListAsync();
            ;
        }

        public async Task AddCopieOfBookById(int id)
        {
            var bookCopy = await _dbContext.BookCopies.Where(c=>c.BookId == id).FirstOrDefaultAsync();

            if(bookCopy != null)
            {
                bookCopy.Quantity += 1;
                
                await _dbContext.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<Review>> GetReviewsOfBookById(int id)
        {

            return await _dbContext.Reviews
                .Include(b => b.Book)
                .Where(r => r.BookId == id).ToListAsync();



        }
    }
}
