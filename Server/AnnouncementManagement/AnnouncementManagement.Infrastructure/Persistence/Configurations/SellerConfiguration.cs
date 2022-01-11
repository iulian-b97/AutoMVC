using AnnouncementManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AnnouncementManagement.Infrastructure.Persistence.Configurations
{
    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.Property(a => a.Username)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(a => a.Phone)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(a => a.Country)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
