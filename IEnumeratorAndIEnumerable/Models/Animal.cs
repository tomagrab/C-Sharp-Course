namespace IEnumerableAndIEnumeratorDemo.Models
{
    class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public Animal()
        {
            Name = "Unknown";
            Type = "Unknown";
            Color = "Unknown";
        }
        public Animal(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nType: {Type}\nColor: {Color}\n";
        }
        public virtual string MakeSound()
        {
            return $"The {Type} makes a sound";
        }
    }
}