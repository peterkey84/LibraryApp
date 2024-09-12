using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;
using LibraryApp.Servicies.Interfaces;

namespace LibraryApp.Servicies.Infrastructure
{
    public class BookService : BaseService<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository) : base(bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<IEnumerable<Book>> GetAvailabilityBooks()
        {
            return _bookRepository.GetAvailabilityBooks();
        }
    }
}
