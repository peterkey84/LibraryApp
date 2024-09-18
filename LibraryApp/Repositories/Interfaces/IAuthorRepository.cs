using LibraryApp.Entities;

namespace LibraryApp.Repositories.Interfaces
{
    public interface IAuthorRepository: IBaseRepository<Author>
    {

        Task<IEnumerable<Book>> GetAllBooksFromAuthor(int id);
        Task<IEnumerable<Author>> FindAuthorByPhrase(string keyword);

    }
}
