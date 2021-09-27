using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.Models.MotorcyclesFolder
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Brand brands { get; set; }
    }
}
