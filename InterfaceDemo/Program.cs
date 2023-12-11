using InterfaceDemo.Interfaces;
using InterfaceDemo.Models;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair = new Chair("Black", "Plastic", 50, "Office Chair");
            Chair recliner = new Chair("Brown", "Leather", 200, "Recliner");

            Car damagedCar = new Car("Red", "Ford", "F150", 2010, 100);

            damagedCar.Destroyables.Add(officeChair);
            damagedCar.Destroyables.Add(recliner);

            damagedCar.Destroy();
        }
    }
}

