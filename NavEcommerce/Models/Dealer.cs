using System.Collections.Generic;

namespace NavEcommerce.Models
{
    public class Dealer
    {
        public int DealerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Motorcycle> Motorcycles { get; set; }
        //public IEnumerable<DealerBrand> BrandDealers { get; set; }
        //public IEnumerable<MotorcycleDealer> MotorcycleDealers { get; set; }
    }
}