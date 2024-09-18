using LibraryApp.Entities;

namespace LibraryApp.Servicies.Interfaces
{
    public interface IRentalService: IBaseService<Rental>
    {
        Task ExtendDateOfReturnBookByRentalId(int id, DateTime newDateOfReturn);
        Task DeleteRentalByRentalId(int rentalId);
    }
}
