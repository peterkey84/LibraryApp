using LibraryApp.DAL;
using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;

namespace LibraryApp.Repositories.Infrastructure
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {

        private readonly LibraryDbContext _dbContext;

        public BookRepository(LibraryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
