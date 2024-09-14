using LibraryApp.Entities;
using LibraryApp.Servicies.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class RentalController : ControllerBase
    {

        private readonly IRentalService _rentalService;

        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet]
        public async Task<IEnumerable<Rental>> GetAllBooksAsync()
        {
            return await _rentalService.GetAllAsync();
        }

        [HttpGet("id")]
        public async Task<Rental> GetBookByIdAsync(int id)
        {
            return await _rentalService.GetByIdAsync(id);
        }

        [HttpDelete("id")]
        public async Task DeleteBookAsync(int id)
        {
            await _rentalService.DeleteAsync(id);
        }

        [HttpPost]
        public async Task AddBookAsync(Rental rental)
        {
            await _rentalService.AddAsync(rental);
        }

        [HttpPut]
        public async Task UpdateBookAsync(Rental rental)
        {
            await _rentalService.UpdateAsync(rental);
        }
    }
}
