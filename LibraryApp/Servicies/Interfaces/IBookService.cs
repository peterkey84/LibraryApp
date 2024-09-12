using LibraryApp.Entities;

namespace LibraryApp.Servicies.Interfaces
{
    public interface IBookService: IBaseService<Book>
    {

        Task<IEnumerable<Book>> GetAvailabilityBooks();

    }
}
