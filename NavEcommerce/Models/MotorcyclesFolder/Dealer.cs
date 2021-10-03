namespace NavEcommerce.Models.MotorcyclesFolder
{
    public class Dealer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public bool Motorcycle { get; set; }
        public Brand Brand { get; set; }
        //public int MotorcycleId { get; set; }
        //public int BrandId { get; set; }
    }
}