using InterfaceDemo.Interfaces;

namespace InterfaceDemo.Models
{
    class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }
        public List<IDestroyable> Destroyables { get; set; }
        public Car(string color, string make, string model, int year, float speed)
        {
            DestructionSound = "BOOM!";
            Destroyables = new List<IDestroyable>();
            this.Color = color;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Speed = speed;
        }

        public void Destroy()
        {
            System.Console.WriteLine($"The {this.Make} {this.Model} has been destroyed with a {this.DestructionSound}!");
            foreach (IDestroyable destroyable in Destroyables)
            {
                destroyable.Destroy();
            }
        }
    }
}