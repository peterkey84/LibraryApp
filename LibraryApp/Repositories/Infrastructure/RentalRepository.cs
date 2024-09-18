using LibraryApp.DAL;
using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Repositories.Infrastructure
{
    public class RentalRepository : BaseRepository<Rental>, IRentalRepository
    {
        private readonly LibraryDbContext _dbContext;

        public RentalRepository(LibraryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteRentalByRentalId(int rentalId)
        {
            var rental = await _dbContext.Rentals.Where(e => e.Id == rentalId).FirstOrDefaultAsync();

            _dbContext.Remove(rental);
            _dbContext.SaveChangesAsync();


        }

        public async Task ExtendDateOfReturnBookByRentalId(int id, DateTime newDateOfReturn)
        {
            var rental = await _dbContext.Rentals.Where(c => c.Id == id).FirstOrDefaultAsync();

            if(rental != null)
            {
                rental.DateOfReturn = newDateOfReturn;

                _dbContext.SaveChangesAsync();
            }
        }
    }
}
