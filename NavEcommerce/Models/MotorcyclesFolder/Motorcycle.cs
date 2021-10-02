using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.Models.MotorcyclesFolder
{
    //This class is cosidered as the parent class
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
    }
}
