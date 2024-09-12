using LibraryApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LibraryApp.EntitiesConfiguration
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.Property(r => r.Fees)
                .HasColumnType("decimal(18,2)");


            builder.HasData(

                new Rental { Id = 1, UserId = 1, BookCopyId = 1, DateOfLoan = DateTime.Now, DateOfReturn = new DateTime(2024, 09, 10) },
                new Rental { Id = 2, UserId = 2, BookCopyId = 1, DateOfLoan = DateTime.Now, DateOfReturn = new DateTime(2024, 10, 10) },
                new Rental { Id = 3, UserId = 3, BookCopyId = 1, DateOfLoan = DateTime.Now, DateOfReturn = new DateTime(2024, 11, 11) },
                new Rental { Id = 4, UserId = 4, BookCopyId = 1, DateOfLoan = DateTime.Now, DateOfReturn = new DateTime(2024, 11, 13) },
                new Rental { Id = 5, UserId = 5, BookCopyId = 1, DateOfLoan = DateTime.Now, DateOfReturn = new DateTime(2024, 12, 15) },
                new Rental { Id = 6, UserId = 1, BookCopyId = 1, DateOfLoan = DateTime.Now, DateOfReturn = new DateTime(2024, 10, 16) },
                new Rental { Id = 7, UserId = 2, BookCopyId = 1, DateOfLoan = DateTime.Now, DateOfReturn = new DateTime(2024, 11, 10) }

                );
        }

    }
}
