using AutoMapper;
using LibraryApp.DTOs.BookDTO;
using LibraryApp.DTOs.ReviewDTO;
using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;
using LibraryApp.Servicies.Interfaces;

namespace LibraryApp.Servicies.Infrastructure
{
    public class BookService : BaseService<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper) : base(bookRepository)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookViewDto>> GetAvailabilityBooks()
        {
            var books = await _bookRepository.GetAvailabilityBooks();

            IEnumerable<BookViewDto> result = _mapper.Map<IEnumerable<BookViewDto>>(books);

            return result;

        }


        public async Task AddCopieOfBookById(int id)
        {
            await _bookRepository.AddCopieOfBookById(id);
        }

        public async Task<IEnumerable<ReviewDto>> GetReviewsOfBookById(int id)
        {
            var reviews = await _bookRepository.GetReviewsOfBookById(id);

            IEnumerable<ReviewDto> reviewDtos = _mapper.Map<IEnumerable<ReviewDto>>(reviews);

            return reviewDtos;

        }

        public async Task UpdateStatusOnRepairOfBookCopyById(int bookId, int bookCopyId)
        {
            await _bookRepository.UpdateStatusOnRepairOfBookCopyById(bookId, bookCopyId);
        }
    }

}    
