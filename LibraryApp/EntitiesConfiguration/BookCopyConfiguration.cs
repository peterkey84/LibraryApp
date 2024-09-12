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
                new BookCopy { Id = 1, BookId = 1, EAN = "5012345678900", Quantity=50},
                new BookCopy { Id = 2, BookId = 2, EAN = "9780201379624", Quantity = 50 },
                new BookCopy { Id = 3, BookId = 3, EAN = "8000500310429", Quantity = 510 },
                new BookCopy { Id = 4, BookId = 4, EAN = "4029764001805", Quantity = 10 },
                new BookCopy { Id = 5, BookId = 5, EAN = "3800029146455", Quantity = 100 },
                new BookCopy { Id = 6, BookId = 6, EAN = "8710123456789", Quantity = 320 },
                new BookCopy { Id = 7, BookId = 7, EAN = "5051234567894", Quantity = 99 },
                new BookCopy { Id = 8, BookId = 8, EAN = "4006381333931", Quantity = 111 }
                );


        }
    }
}
