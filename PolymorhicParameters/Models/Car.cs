namespace Polymorphism.Models
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }
        public Car()
        {
            HP = 100;
            Color = "Black";
        }
        public Car(int hp, string color)
        {
            HP = hp;
            Color = color;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine($"HP: {HP} Color: {Color}");
        }
        public virtual void Repair()
        {
            System.Console.WriteLine("Car was repaired!");
        }
    }
}