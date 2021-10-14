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

        private IGenericRepo<Motorcycle> motorcycleRepositoriy;
        public IGenericRepo<Motorcycle> MotorcycleRepository
        {
            get
            {
                if (motorcycleRepositoriy == null)
                {
                    motorcycleRepositoriy = new MotorcycleRepo(_context);
                }
                return motorcycleRepositoriy;
            }
        }

        private IGenericRepo<Brand> brandRepository;
        public IGenericRepo<Brand> BrandRepository
        {
            get
            {
                if (brandRepository == null)
                {
                    brandRepository = new BrandRepo(_context);
                }
                return brandRepository;
            }
        }
    }
}
