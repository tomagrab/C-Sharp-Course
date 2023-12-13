namespace Polymorphism.Models
{
    class Audi : Car
    {
        private string Brand = "Audi";
        public string Model { get; set; }
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
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