
using System.Collections.Generic;

namespace NavEcommerce.Models.MotorcyclesFolder
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Motorcycle> Motorcycles { get; set; }
        public IEnumerable<Dealer> Dealers { get; set; }
    }
}