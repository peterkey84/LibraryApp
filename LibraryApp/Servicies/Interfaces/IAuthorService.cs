using LibraryApp.Entities;

namespace LibraryApp.Servicies.Interfaces
{
    public interface IAuthorService: IBaseService<Author>
    {

        Task<IEnumerable<Book>> GetAllBooksFromAuthorAsync(int id);
        Task<Author> FindAuthorByPhraseAsync(string keyword);


    }
}
