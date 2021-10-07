using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.Models
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public Brand Brands { get; set; }
    }
}
