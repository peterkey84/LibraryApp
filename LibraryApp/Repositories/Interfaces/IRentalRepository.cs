using LibraryApp.Entities;

namespace LibraryApp.Repositories.Interfaces
{
    public interface IRentalRepository: IBaseRepository<Rental>
    {
        Task ExtendDateOfReturnBookByRentalId(int id, DateTime newDateOfReturn);
        Task DeleteRentalByRentalId(int rentalId);
    }
}
