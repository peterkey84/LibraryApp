using LibraryApp.DTOs.BookDTO;
using LibraryApp.DTOs.ReviewDTO;
using LibraryApp.Entities;

namespace LibraryApp.Servicies.Interfaces
{
    public interface IBookService: IBaseService<Book>
    {

        Task<IEnumerable<BookViewDto>> GetAvailabilityBooks();
        Task AddCopieOfBookById(int id);
        Task<IEnumerable<ReviewDto>> GetReviewsOfBookById(int id);
        Task UpdateStatusOnRepairOfBookCopyById(int bookId, int bookCopyId);

    }
}
