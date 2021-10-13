using NavEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavEcommerce.infrastructures
{
    public class DataCombiner
    {
        public int MotorcycleId { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public DataCombiner(int motorId, string model, double price)
        {
            MotorcycleId = motorId;
            Model = model;
            Price = price;
        }
        public void CombineMotorBrandData()
        {
            var brand = new Brand();
            brand.Motorcycles.ToList();

        }
    }
}
