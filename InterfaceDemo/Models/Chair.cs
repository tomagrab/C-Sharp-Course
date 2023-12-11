using InterfaceDemo.Interfaces;

namespace InterfaceDemo.Models
{
    class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }

        public Chair(string color, string material, decimal price, string name)
        {
            this.DestructionSound = "CRASH!";
            this.Color = color;
            this.Material = material;
            this.Price = price;
            this.Name = name;
        }

        public void Destroy()
        {
            System.Console.WriteLine($"The {this.Name} has been destroyed with a {this.DestructionSound}!");
        }
    }
}