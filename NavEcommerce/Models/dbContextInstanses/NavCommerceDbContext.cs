using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NavEcommerce.Models.MotorcyclesFolder;

namespace NavEcommerce.Models.dbContextInstanses
{
    public class NavCommerceDbContext : DbContext
    {
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
