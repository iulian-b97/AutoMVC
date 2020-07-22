using AutoMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMVC.Data
{
    public class AutoStoreContext : DbContext
    {
        public AutoStoreContext(DbContextOptions<AutoStoreContext> options) : base(options)
        {

        }

        public DbSet<CarModel> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=AutoMVC;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
