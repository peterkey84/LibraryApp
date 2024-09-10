using LibraryApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApp.EntitiesConfiguration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {


            builder.HasData(

                new Book { Id = 1, Title= "Na zdrowie", Description = "Jest to fraszka napisana na zdrowie i dla zdrowia wszystkich", AuthorId = 1, CreatedDate= new DateTime(2024,01,01) },
                new Book { Id = 2, Title= "Pieśń świętojańska o Sobótce", Description = "Jest to pieśń o Sobótce", AuthorId = 1, CreatedDate = new DateTime(2023,01,02) },
                new Book { Id = 3, Title = "Leń", Description = "Bajka dla dzieci o leniu co nić nie robi cały dzień", AuthorId = 2, CreatedDate= new DateTime(2024,01,02)},
                new Book { Id = 4, Title = "Na wyspach Bergamutach", Description = "Bardzo zabawna rymowanka o nieistniejących wyspach", AuthorId = 2, CreatedDate = new DateTime(2020,01,01) },
                new Book { Id = 5, Title = "Nic dwa razy się nie zdarza/ i nie zdarzy", Description = "Najpopularniejszym chyba wierszem", AuthorId = 3, CreatedDate = new DateTime(2020,01,02)},
                new Book { Id = 6, Title = "Solaris", Description = "To najsłynniejsza powieść Stanisława Lema", AuthorId = 4, CreatedDate = new DateTime(2021,03,04) },
                new Book { Id = 7, Title = "Erynie", Description = "Zbiór opowiadań o komisarzu Popielskim", AuthorId = 5, CreatedDate = new DateTime(2020,01,05) },
                new Book { Id = 8, Title = "Śmierć w Breslau", Description = "Zbiór opowiadań o komisarzu Mocku", AuthorId = 5, CreatedDate = new DateTime(1999,01,02)}

                );
        }
    }
}
