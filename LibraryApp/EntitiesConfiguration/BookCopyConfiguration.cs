using LibraryApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApp.EntitiesConfiguration
{
    public class BookCopyConfiguration : IEntityTypeConfiguration<BookCopy>

    {
        public void Configure(EntityTypeBuilder<BookCopy> builder)
        {


            builder.HasData
                (
                new BookCopy { Id = 1, BookId = 1, EAN = "5012345678900", IsAvailable = true, Status = Enums.BookStatus.Available},
                new BookCopy { Id = 2, BookId = 1, EAN = "9780201379624", IsAvailable = true, Status = Enums.BookStatus.Available },
                new BookCopy { Id = 3, BookId = 2, EAN = "8000500310429", IsAvailable = false, Status = Enums.BookStatus.Borrowed },
                new BookCopy { Id = 4, BookId = 2, EAN = "4029764001805", IsAvailable = false, Status = Enums.BookStatus.Borrowed },
                new BookCopy { Id = 5, BookId = 2, EAN = "3800029146455", IsAvailable = true, Status = Enums.BookStatus.Available },
                new BookCopy { Id = 6, BookId = 3, EAN = "8710123456789", IsAvailable = false, Status = Enums.BookStatus.Borrowed },
                new BookCopy { Id = 7, BookId = 3, EAN = "5051234567894", IsAvailable = true, Status = Enums.BookStatus.Available },
                new BookCopy { Id = 8, BookId = 3, EAN = "4006381333931", IsAvailable = false, Status = Enums.BookStatus.Borrowed },
                new BookCopy { Id = 9, BookId = 3, EAN = "4006381333931", IsAvailable = false, Status = Enums.BookStatus.InRepair, RepairComment = "Ksiązka z uszkodzoną okładką, do wymiany okładka przednia." }

                );


        }
    }
}
