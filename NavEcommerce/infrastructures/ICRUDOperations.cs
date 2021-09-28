using NavEcommerce.Models.MotorcyclesFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures
{
    interface ICRUDOperations
    {
        public Motorcycle Add(Motorcycle motorcycle);
    }
}
