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
        //    modelBuilder.Entity<Brand>()
        //        .HasMany(m => m.Dealers)
        //        .WithMany(b => b.Brands)
        //        .UsingEntity<BrandDealer>
        //        (bm => bm.HasOne<Brand>().WithMany(),
        //        bm => bm.HasOne<Motorcycle>().WithMany())
        //        .Property(bm => bm.Dealers);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<MotorcycleDealer>()
            // .HasKey(md => new { md.MotorcycleId, md.DealerId });

            //modelBuilder.Entity<DealerBrand>()
            // .HasKey(bd => new { bd.BrandId, bd.DealerId });

            //modelBuilder.Entity<MotorcycleDealer>()
            //    .HasOne<Motorcycle>(md => md.Motorcycle)
            //    .WithMany(m => m.MotorcycleDealers)
            //    .HasForeignKey(md => md.MotorcycleId);
            //modelBuilder.Entity<MotorcycleDealer>()
            //    .HasOne<Dealer>(md => md.Dealer)
            //    .WithMany(m => m.MotorcycleDealers)
            //    .HasForeignKey(md => md.DealerId);

            //modelBuilder.Entity<BrandDealer>()
            //    .HasOne<Brand>(bd => bd.Brand)
            //    .WithMany(b => b.BrandDealers)
            //    .HasForeignKey(bd => bd.BrandId);
            //modelBuilder.Entity<BrandDealer>()
            //    .HasOne<Dealer>(bd => bd.Dealer)
            //    .WithMany(b => b.BrandDealers)
            //    .HasForeignKey(bd => bd.DealerId);
        }

        public DbSet<Motorcycle> Motorcycles { get; set; }

        public DbSet<Brand> Brands { get; set; }
        
        public DbSet<Dealer> Dealers { get; set; }

    }
}
