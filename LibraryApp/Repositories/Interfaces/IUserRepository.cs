using LibraryApp.Entities;

namespace LibraryApp.Repositories.Interfaces
{
    public interface IUserRepository: IBaseRepository<User>
    {
        Task<IEnumerable<Rental>> GetHistoryOfRentaledBooksOfUserByIdAsync(int id);
        Task<IEnumerable<Rental>> GetAllActiveRentaledBookOfUserByIdAsync(int id);
        Task ExtendRentalBookofUserByIdAsync(int id, DateTime dateOfReturn);
    }
}
