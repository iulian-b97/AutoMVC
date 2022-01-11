using AnnouncementManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AnnouncementManagement.Infrastructure.Persistence.Configurations
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Price)
                .IsRequired();

            builder.Property(a => a.Description)
                .IsRequired();
        }
    }
}
