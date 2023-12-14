using Polymorphism.Models;

namespace Polymorphism
{
    class Program
    {
        /* 
            * Create a base class Car with two properties HP and Color
            * Create a constructor that sets the values of the properties
            * Create a method ShowDetails() that prints the values of the properties
            * Create a method Repair() that prints "Car was repaired!"
            * Create a two derived classes Audi and BMW, which have their own constructors and have an additional property
            * called Model. Also a private member called brand that is set in the constructor.
            * Create a method ShowDetails() that prints the values of the properties including the private member brand
         */
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car(100, "Black"));
            cars.Add(new BMW(200, "Red", "M3"));
            cars.Add(new Audi(150, "White", "A4"));
            cars.Add(new M3(300, "Green"));

            foreach (var car in cars)
            {
                car.ShowDetails();
                car.Repair();
            }

            BMW bmw23 = new BMW(300, "Blue", "M3");
            bmw23.SetCarIDInfo(1234, "John Doe");
            bmw23.GetCarIDInfo();


        }
    }
}