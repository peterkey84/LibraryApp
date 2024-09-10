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


        }

    }
}
