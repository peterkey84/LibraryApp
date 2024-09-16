using LibraryApp.DAL;
using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Repositories.Infrastructure
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly LibraryDbContext _dbContext;

        public UserRepository(LibraryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IEnumerable<Rental>> GetHistoryOfRentaledBooksOfUserByIdAsync(int id)
        {
            return await _dbContext.Rentals.Where(c => c.UserId == id).ToListAsync();
        }


        public async Task<IEnumerable<Rental>> GetAllActiveRentaledBookOfUserByIdAsync(int id)
        {
            return await _dbContext.Rentals.Where(d => d.DateOfReturn == null && d.UserId == id).ToListAsync();
        }

        public async Task ExtendRentalBookofUserByIdAsync(int id, DateTime dateOfReturn)
        {
            var rental = await _dbContext.Rentals.FindAsync(id);

            if(rental == null)
            {
                throw new Exception();
            }

            rental.DateOfReturn = dateOfReturn;

            await _dbContext.SaveChangesAsync();
        }
    }
}
