namespace InterfaceDemo.Models
{
    class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public Furniture()
        {
            Color = "White";
            Material = "Wood";
            Price = 100;
            Name = "Chair";
        }
        public Furniture(string color, string material, decimal price, string name)
        {
            Color = color;
            Material = material;
            Price = price;
            Name = name;
        }
    }
}