using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Carsales.Core;

namespace Carsales.EntityFrameworkCore
{
    public class CarsalesDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Car> Cars { get; set; }

        public CarsalesDbContext(DbContextOptions<CarsalesDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().ToTable("Vehicle");
        }
    }
}
