using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;
using LibraryApp.Servicies.Interfaces;

namespace LibraryApp.Servicies.Infrastructure
{
    public class AuthorService : BaseService<Author>, IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository) : base(authorRepository)
        {
            _authorRepository = authorRepository;

        }

        public async Task<IEnumerable<Author>> FindAuthorByPhraseAsync(string keyword)
        {
            return await _authorRepository.FindAuthorByPhrase(keyword);
        }

        public Task<IEnumerable<Book>> GetAllBooksFromAuthorAsync(int id)
        {
           return _authorRepository.GetAllBooksFromAuthor(id);
        }
    }
}
