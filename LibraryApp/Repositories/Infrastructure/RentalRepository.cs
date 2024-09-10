using LibraryApp.DAL;
using LibraryApp.Entities;
using LibraryApp.Repositories.Interfaces;

namespace LibraryApp.Repositories.Infrastructure
{
    public class RentalRepository : BaseRepository<Rental>, IRentalRepository
    {
        private readonly LibraryDbContext _dbContext;

        public RentalRepository(LibraryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
