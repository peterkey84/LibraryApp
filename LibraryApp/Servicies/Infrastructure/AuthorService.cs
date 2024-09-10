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
    }
}
