using LibraryApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace LibraryApp.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(

                new User { Id = 1, FirstName = "Jan", LastName = "Kowalski", DateOfBirth = new DateTime(1984,01,03), ContactNumber = "888333222", Email= "jan@kowalksi.pl", City = "Gdańsk", Street = "Grunwaldzka", PostalCode = "80-110", },
                new User { Id = 2, FirstName = "Paweł", LastName = "Lelek", DateOfBirth = new DateTime(1994, 01, 03), ContactNumber = "333444555", Email = "pawel@kowalksi.pl", City = "Gdynia", Street = "Grunwaldzka", PostalCode = "81-110", },
                new User { Id = 3, FirstName = "Piotr", LastName = "Kaminski", DateOfBirth = new DateTime(1974, 01, 03), ContactNumber = "888111222", Email = "piotr@kowalksi.pl", City = "Sopot", Street = "Grunwaldzka", PostalCode = "82-110", },
                new User { Id = 4, FirstName = "Wiesław", LastName = "XXX", DateOfBirth = new DateTime(1954, 01, 03), ContactNumber = "888336666", Email = "jan@sss.pl", City = "Rumia", Street = "Grunwaldzka", PostalCode = "85-110", },
                new User { Id = 5, FirstName = "Olek", LastName = "Misztal", DateOfBirth = new DateTime(1934, 01, 03), ContactNumber = "888333231", Email = "jan@kfff.pl", City = "Żukowo", Street = "Grunwaldzka", PostalCode = "86-110", }

                );
        }
    }
}
