namespace Cars.WebAPI.Models
{
    public class Car
    {
        public int CarId { get; }
        public string Brand { get; set; }
        public int Power { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }

        public Car(int carId, string brand, int power, decimal price, string color)
        {
            CarId = carId;
            Brand = brand;
            Power = power;
            Price = price;
            Color = color;
        }
    }
}