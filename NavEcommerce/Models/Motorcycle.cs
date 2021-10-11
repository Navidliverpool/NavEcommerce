using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.Models
{
    public class Motorcycle
    {
        [DisplayName("Id")]
        public int MotorcycleId { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public Brand Brand { get; set; }
        public IEnumerable<Dealer> Dealers { get; set; }
        //public IEnumerable<MotorcycleDealer> MotorcycleDealers { get; set; }
    }
}
