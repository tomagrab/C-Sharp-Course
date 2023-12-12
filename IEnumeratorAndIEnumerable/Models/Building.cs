namespace IEnumerableAndIEnumeratorDemo.Models
{
    class Building
    {
        public string Name { get; set; }

        public Building(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}