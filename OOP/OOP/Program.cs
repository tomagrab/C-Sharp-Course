using System;

namespace OOP
{
    // A class is a blueprint of an Object
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi", "A4", "Black", 2019);

            Console.WriteLine(audi.Name);
            Console.WriteLine(audi.Make);
            Console.WriteLine(audi.Model);
            Console.WriteLine(audi.Color);
            Console.WriteLine(audi.YearBuilt);

            audi.Accelerate();
        }
    }
}