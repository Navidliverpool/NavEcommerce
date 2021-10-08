using System.Collections.Generic;

namespace NavEcommerce.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Motorcycle> Motorcycles { get; set; }
        public IEnumerable<Dealer> Dealers { get; set; }
        //public IEnumerable<DealerBrand> BrandDealers { get; set; }
    }
}