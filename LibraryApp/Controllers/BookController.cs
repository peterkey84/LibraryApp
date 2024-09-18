using LibraryApp.DTOs.BookDTO;
using LibraryApp.DTOs.ReviewDTO;
using LibraryApp.Entities;
using LibraryApp.Servicies.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookServic)
        {
            _bookService = bookServic;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _bookService.GetAllAsync();
        }

        [HttpGet("id")]
        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _bookService.GetByIdAsync(id);
        }

        [HttpDelete("id")]
        public async Task DeleteBookAsync(int id)
        {
            await _bookService.DeleteAsync(id);
        }

        [HttpPost]
        public async Task AddBookAsync(Book book)
        {
            await _bookService.AddAsync(book);
        }

        [HttpPut]
        public async Task UpdateBookAsync(Book book)
        {
            await _bookService.UpdateAsync(book);
        }

        [HttpGet("availability")]
        public async Task<IEnumerable<BookViewDto>> GetAvailabilityBooks()
        {
            return await _bookService.GetAvailabilityBooks();
            //TODO dodać ilość dostepnych książek
        }

        [HttpPost("new-copies/{bookId}")]
        public async Task AddCopieOfBookByIdAsync(int bookId)
        {
            await _bookService.AddCopieOfBookById(bookId);
        }

        [HttpGet("{bookId}/reviews")]
        public async Task<IEnumerable<ReviewDto>> GetReviewsOfBookById(int bookId)
        {
            return await _bookService.GetReviewsOfBookById(bookId);
        }

        //TODO HttpPost, HttpPut i HttpDelete do Reviews.

        [HttpPut("{bookId}/bookCopies/{bookCopieId}/repair")]
        public async Task UpdateStatusOnRepairOfBookCopyById(int bookId, int bookCopieId)
        {
            await _bookService.UpdateStatusOnRepairOfBookCopyById(bookId, bookCopieId);
        }

    }
}
