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


    }
}
