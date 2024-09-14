using LibraryApp.Entities;
using LibraryApp.Servicies.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetAllBooksAsync()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("id")]
        public async Task<User> GetBookByIdAsync(int id)
        {
            return await _userService.GetByIdAsync(id);
        }

        [HttpDelete("id")]
        public async Task DeleteBookAsync(int id)
        {
            await _userService.DeleteAsync(id);
        }

        [HttpPost]
        public async Task AddBookAsync(User user)
        {
            await _userService.AddAsync(user);
        }

        [HttpPut]
        public async Task UpdateBookAsync(User user)
        {
            await _userService.UpdateAsync(user);
        }
    }
}
