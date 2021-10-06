using Microsoft.EntityFrameworkCore;
using NavEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures.DbContextInstances
{
    public class NavEcommerceDbContext : DbContext
    {
        public NavEcommerceDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Motorcycle>()
        //        .HasMany(m => m.Brands)
        //        .WithMany(b => b.Motorcycles)
        //        .UsingEntity<BrandMotorcycle>
        //        (bm => bm.HasOne<Brand>().WithMany(),
        //        bm => bm.HasOne<Motorcycle>().WithMany())
        //        .Property(bm => bm.Dealers);
        //}

        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Dealer> Dealers { get; set; }

    }
}
