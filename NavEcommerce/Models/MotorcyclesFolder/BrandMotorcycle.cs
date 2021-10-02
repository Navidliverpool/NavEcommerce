using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.Models.MotorcyclesFolder
{
    public class BrandMotorcycle
    {
        public int MotorcycleId { get; set; }
        public int BrandId { get; set; }
        public IEnumerable<Dealer> Dealers { get; set; }
    }
}
