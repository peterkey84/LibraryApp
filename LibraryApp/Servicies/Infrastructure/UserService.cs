using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;
using LibraryApp.Servicies.Interfaces;

namespace LibraryApp.Servicies.Infrastructure
{
    public class UserService : BaseService<User>, IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Rental>> GetHistoryOfRentaledBooksOfUserByIdAsync(int id)
        {
            return await _userRepository.GetHistoryOfRentaledBooksOfUserByIdAsync(id);
        }


        public async Task<IEnumerable<Rental>> GetAllActiveRentaledBookOfUserByIdAsync(int id)
        {
            return await _userRepository.GetAllActiveRentaledBookOfUserByIdAsync(id);
        }

        public async Task ExtendRentalBookofUserByIdAsync(int id, DateTime dateOfReturn)
        {
            await _userRepository.ExtendRentalBookofUserByIdAsync(id, dateOfReturn);
        }
    }
}
