using LibraryApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DAL
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options){}

        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }  
        public DbSet<Book> Books { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }
    }
}
