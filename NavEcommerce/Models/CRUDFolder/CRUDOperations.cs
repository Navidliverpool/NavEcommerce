using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NavEcommerce.Models.DbContextFolder;
using NavEcommerce.Models.MotorcyclesFolder;

namespace NavEcommerce.Models.CRUDFolder
{
    public class CRUDOperations
    {
        private NavEcommerceDbContext _context;
        public CRUDOperations(NavEcommerceDbContext context)
        {
            context = _context;
        }

        public void Add(Motorcycle motorcycle)
        {
            if (motorcycle == null)
            {
                 throw new ArgumentNullException();
            }

            _context.Motorcycles.Add(motorcycle);
        }
    }
}
