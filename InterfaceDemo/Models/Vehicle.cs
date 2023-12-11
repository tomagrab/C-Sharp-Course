namespace InterfaceDemo.Models
{
    public class Vehicle
    {
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public float Speed { get; set; }
        public Vehicle()
        {
            Color = "White";
            Make = "Ford";
            Model = "F150";
            Year = 2018;
            Speed = 100f;
        }
        public Vehicle(string color, string make, string model, int year, float speed)
        {
            Color = color;
            Make = make;
            Model = model;
            Year = year;
            Speed = speed;
        }
    }
}