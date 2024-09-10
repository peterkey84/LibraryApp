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
    }
}
