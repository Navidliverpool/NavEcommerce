using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NavEcommerce.infrastructures;
using NavEcommerce.Models.DbContextFolder;
using NavEcommerce.Models.MotorcyclesFolder;

namespace NavEcommerce.Models.CRUDFolder
{
    public class CRUDOperations : ICRUDOperations
    {
        private NavEcommerceDbContext _context;
        public CRUDOperations(NavEcommerceDbContext context)
        {
            context = _context;
        }

        public Motorcycle Add(Motorcycle motorcycle)
        {
            if (motorcycle == null)
            {
                 throw new ArgumentNullException();
            }

            var motor = _context.Motorcycles.Add(motorcycle).Entity;

            return motor;
        }
    }
}
