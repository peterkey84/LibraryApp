using LibraryApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApp.EntitiesConfiguration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {

            builder.HasData
                (

                new Author { Id= 1, FirstName= "Jan", LastName="Kochanowski", DateOfBirth= new DateTime(1530,1,1)},
                new Author { Id = 2, FirstName= "Jan", LastName="Brzechwa", DateOfBirth=new DateTime(1898,8,15)},
                new Author { Id= 3, FirstName = "Wisława", LastName="Szymborska", DateOfBirth = new DateTime(1923,7,2)},
                new Author { Id= 4, FirstName = "Stanisław", LastName="Lem", DateOfBirth = new DateTime(1921, 9,12)},
                new Author { Id= 5, FirstName = "Marek", LastName= "Krajweski", DateOfBirth = new DateTime(1966, 9,4)}

                );


        }
    }
}
