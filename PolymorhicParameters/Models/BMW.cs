namespace Polymorphism.Models
{
    class BMW : Car
    {
        private string Brand = "BMW";
        public string Model { get; set; }
        public BMW(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public BMW()
        {
            Model = "M3";
        }

        public new void ShowDetails()
        {
            System.Console.WriteLine($"Brand: {Brand} HP: {HP} Color: {Color} Model: {Model}");
        }

        public override void Repair()
        {
            System.Console.WriteLine($"{Brand} {Model} was repaired!");
        }
    }
}