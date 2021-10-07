using System.Collections.Generic;

namespace NavEcommerce.Models
{
    public class Dealer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public IEnumerable<Brand> Brand { get; set; }
        //public int MotorcycleId { get; set; }
        //public int BrandId { get; set; }
    }
}