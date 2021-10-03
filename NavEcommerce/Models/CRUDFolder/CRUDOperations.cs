using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NavEcommerce.infrastructures;
using NavEcommerce.Models.DbContextFolder;
using NavEcommerce.Models.MotorcyclesFolder;

namespace NavEcommerce.Models.CRUDFolder
{
    public class CRUDOperations<T> where T : class , ICRUDOperations<T>
    {
        private NavEcommerceDbContext _context;
        public CRUDOperations(NavEcommerceDbContext context)
        {
            context = _context;
        }

        public void Add(T t)
        {
            if (t == null)
            {
                 throw new ArgumentNullException();
            }

            var motor = _context.Add(t).Entity;
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var removeTheItem = _context.Remove(id);
            _context.SaveChanges();
        }

        public virtual T Get(int t)
        {

           return _context.Find<T>(t);
        }
      
    }
}
