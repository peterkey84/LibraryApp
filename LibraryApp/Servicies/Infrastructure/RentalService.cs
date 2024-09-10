using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;
using LibraryApp.Servicies.Interfaces;

namespace LibraryApp.Servicies.Infrastructure
{
    public class RentalService : BaseService<Rental>, IRentalService
    {

        private readonly IRentalRepository _rentalRepository;

        public RentalService(IRentalRepository rentalRepository) : base(rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }
    }
}
