
using System.Collections.Generic;

namespace NavEcommerce.Models.MotorcyclesFolder
{
    //This class is cosidered as the child class
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Motorcycle> Motorcycles { get; set; }
    }
}