using AnnouncementManagement.Domain.Entities;
using AnnouncementManagement.Domain.Entities.Vehicle;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Infrastructure.Persistence
{
    public class AnnouncementContext : DbContext
    {
        public AnnouncementContext(DbContextOptions<AnnouncementContext> options) : base(options)
        {

        }

        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Motorcycle> Motorcycles { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }
        public virtual DbSet<Van> Vans { get; set; }
        public virtual DbSet<Trailer> Trailers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PK
            modelBuilder.Entity<Announcement>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Seller>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Car>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Motorcycle>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Truck>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Van>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Trailer>()
                .HasKey(x => x.Id);

            //Seller - Announcement (one to many)
            modelBuilder.Entity<Seller>()
                .HasMany(x => x.Announcements)
                .WithOne(y => y.Seller)
                .HasForeignKey(y => y.SellerId);

            //Announcement - Car (one to one)
            modelBuilder.Entity<Announcement>()
                .HasOne(x => x.Car)
                .WithOne(y => y.Announcement)
                .HasForeignKey<Car>(y => y.AnnouncementId);

            //Announcement - Motorcycle (one to one)
            modelBuilder.Entity<Announcement>()
                .HasOne(x => x.Motorcycle)
                .WithOne(y => y.Announcement)
                .HasForeignKey<Motorcycle>(y => y.AnnouncementId);

            //Announcement - Truck (one to one)
            modelBuilder.Entity<Announcement>()
                .HasOne(x => x.Truck)
                .WithOne(y => y.Announcement)
                .HasForeignKey<Truck>(y => y.AnnouncementId);

            //Announcement - Van (one to one)
            modelBuilder.Entity<Announcement>()
                .HasOne(x => x.Van)
                .WithOne(y => y.Announcement)
                .HasForeignKey<Van>(y => y.AnnouncementId);

            //Announcement - Trailer (one to one)
            modelBuilder.Entity<Announcement>()
                .HasOne(x => x.Trailer)
                .WithOne(y => y.Announcement)
                .HasForeignKey<Trailer>(y => y.AnnouncementId);
        }
    }
}
