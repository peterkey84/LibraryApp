using LibraryApp.DAL;
using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Repositories.Infrastructure
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        private readonly LibraryDbContext _dbContext;

        public AuthorRepository(LibraryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Book>> GetAllBooksFromAuthor(int authorId)
        {

            return await _dbContext.Books
                .Where(i => i.AuthorId == authorId)
                .ToListAsync();

        }

        public async Task<Author> FindAuthorByPhrase(string keyword)
        {

            var authors = await _dbContext.Authors
                .Where(f => f.FirstName.Contains(keyword) ||
                f.LastName.Contains(keyword)
                ).ToListAsync();

            return authors.FirstOrDefault();

        }
    }
}
