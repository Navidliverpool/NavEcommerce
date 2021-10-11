using NavEcommerce.infrastructures.DbContextInstances;
using NavEcommerce.infrastructures.Repositories;
using NavEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private NavEcommerceDbContext _context;
        public UnitOfWork(NavEcommerceDbContext context)
        {
            _context = context;
        }

        private IGenericRepo<Motorcycle> motorcycleRepo;
        public IGenericRepo<Motorcycle> MotorcycleRepo
        {
            get
            {
                if (motorcycleRepo == null)
                {
                    motorcycleRepo = new MotorcycleRepo(_context);
                }
                return motorcycleRepo;
            }
        }

        private IGenericRepo<Brand> brandRepo;
        public IGenericRepo<Brand> BrandRepo
        {
            get
            {
                if (brandRepo == null)
                {
                    brandRepo = new BrandRepo(_context);
                }
                return brandRepo;
            }
        }
    }
}
