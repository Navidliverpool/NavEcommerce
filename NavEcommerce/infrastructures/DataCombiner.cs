using NavEcommerce.infrastructures.DbContextInstances;
using NavEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures
{
    public class DataCombiner : IDataCombiner
    {
        private readonly NavEcommerceDbContext _context;
        public DataCombiner(NavEcommerceDbContext context)
        {
            _context = context;
        }

        public DataCombiner()
        {

        }

        public IQueryable<Motorcycle> CombineMotorBrandData()
        {
                      return from a in _context.Motorcycles
                             join b in _context.Brands
                             on a.Brand.BrandId equals b.BrandId
                             select new Motorcycle
                             {
                                 MotorcycleId = a.MotorcycleId,
                                 Model = a.Model,
                                 Price = a.Price,
                                 Brand = new Brand
                                 {
                                     BrandId = b.BrandId,
                                     Name = b.Name
                                 }
                             };

        }
    }
}
