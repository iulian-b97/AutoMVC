using AnnouncementManagement.Domain.Entities.Vehicle;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AnnouncementManagement.Infrastructure.Persistence.Configurations.Vehicle
{
    public class TrailerConfiguration : IEntityTypeConfiguration<Trailer>
    {
        public void Configure(EntityTypeBuilder<Trailer> builder)
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

            builder.Property(a => a.NumberDoors)
                .IsRequired();
        }
    }
}
