using NavEcommerce.Models;

namespace NavEcommerce.ViewModels
{
    public class MotorcycleModel
    {
        public int MotorcycleId { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public Brand Brand { get; set; }
    }
}