using AnnouncementManagement.Domain.Entities.Vehicle;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AnnouncementManagement.Infrastructure.Persistence.Configurations.Vehicle
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(a => a.Mark)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Model)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Year)
                .IsRequired();

            builder.Property(a => a.Body)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.ColorBody)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Km)
                .IsRequired();

            builder.Property(a => a.HP)
                .IsRequired();

            builder.Property(a => a.FuelType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Cm3)
                .IsRequired();

            builder.Property(a => a.Gearbox)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Speeds)
                .IsRequired();

            builder.Property(a => a.Cylinders)
                .IsRequired();

            builder.Property(a => a.Traction)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Paint)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.NumberDoors)
                .IsRequired();

            builder.Property(a => a.NumberSeats)
                .IsRequired();

            builder.Property(a => a.Weight)
                .IsRequired();
        }
    }
}
