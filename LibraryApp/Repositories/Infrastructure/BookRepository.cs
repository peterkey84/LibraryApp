using LibraryApp.DAL;
using LibraryApp.EanGenertor;
using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Repositories.Infrastructure
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {

        private readonly LibraryDbContext _dbContext;
        private readonly EanGenerator _eanGenertor;


        public BookRepository(LibraryDbContext dbContext, EanGenerator eanGenerator) : base(dbContext)
        {
            _dbContext = dbContext;
            _eanGenertor = eanGenerator;

        }

        public async Task<IEnumerable<Book>> GetAvailabilityBooks()
        {
            return await _dbContext.Books
                .Include(a => a.Author)
                .Include(b => b.BookCopies)
                .Where(a => a.BookCopies.Any(a => a.IsAvailable))
                .ToListAsync();

            
        }

        public async Task AddCopieOfBookById(int id)
        {

            var newCopy = new BookCopy();
            var book = await _dbContext.Books.Where(c => c.Id == id).FirstOrDefaultAsync();

            if (book != null)
            {
                newCopy.EAN = _eanGenertor.GenerateEan();
                newCopy.IsAvailable = true;
                newCopy.BookId = book.Id;

                await _dbContext.BookCopies.AddAsync(newCopy);

                await _dbContext.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<Review>> GetReviewsOfBookById(int id)
        {

            return await _dbContext.Reviews
                .Include(b => b.Book)
                .Where(r => r.BookId == id).ToListAsync();



        }

        public async Task UpdateStatusOnRepairOfBookCopyById(int bookId, int bookCopyId)
        {

            var bookCopyToUpdate = await _dbContext.BookCopies.Where(b => b.BookId == bookId && b.Id == bookCopyId).FirstOrDefaultAsync();

            if(bookCopyToUpdate != null)
            {
                bookCopyToUpdate.Status = Enums.BookStatus.InRepair;

                await _dbContext.SaveChangesAsync();
            }

        }
    }
}
