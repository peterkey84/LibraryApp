using LibraryApp.Entities;

namespace LibraryApp.Servicies.Interfaces
{
    public interface IUserService: IBaseService<User>
    {

        Task<IEnumerable<Rental>> GetHistoryOfRentaledBooksOfUserByIdAsync(int id);
        Task<IEnumerable<Rental>> GetAllActiveRentaledBookOfUserByIdAsync(int id);
        Task ExtendRentalBookofUserByIdAsync(int id, DateTime dateOfReturn);

    }
}
