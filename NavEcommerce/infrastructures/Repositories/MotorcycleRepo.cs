using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NavEcommerce.infrastructures.DbContextInstances;
using NavEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures.Repositories
{
    public class MotorcycleRepo : GenericRepo<Motorcycle>
    {
        public MotorcycleRepo(NavEcommerceDbContext context) : base(context)
        {
        }

        public override IEnumerable<Motorcycle> Get(int? id)
        {
            return _context.Motorcycles
                .Where(m => m.MotorcycleId == id)
                .ToList();
            //OrderBy(m => m.Model);

            //return from m in _context.Motorcycles
            //       where m.MotorcycleId == id
            //       select m;
        }

        public override IQueryable<Motorcycle> GetAll()
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

        public override Motorcycle Delete(Motorcycle entity)
        {
            //var queryDelete = _context.Motorcycles
            //    .FirstOrDefault(m => m.MotorcycleId == entity.MotorcycleId);
            //return _context.Remove(queryDelete).Entity;

            //var queryGet = _context.Motorcycles
            //   .FirstOrDefault(m => m.MotorcycleId == entity.MotorcycleId);
            //var queryDelete = _context.Remove(queryGet).Entity;
            //_context.Entry(entity).State = EntityState.Modified;

           
                
            return _context.Remove(_context.Motorcycles
                .FirstOrDefault(m => m.MotorcycleId == entity.MotorcycleId)).Entity;

        }

        //public override IEnumerable<Motorcycle> GetByName(string name)
        //{
        //    return _context.Motorcycles
        //        .Where(m => m.Model == name)
        //        //.OrderBy(m => m.Brand)
        //        //.ThenBy(m => m.Model)
        //        .ToList();

        //}



    }
}
