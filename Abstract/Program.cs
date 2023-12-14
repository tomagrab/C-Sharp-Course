using AbstractClasses.Models.Shapes;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(5), new Cube(4) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"Volume: {shape.Volume():N2}");
                Cube isCube = shape as Cube;
                if (isCube == null)
                {
                    Console.WriteLine($"{shape.Name} is not a Cube");
                }
                if (shape is Sphere)
                {
                    Console.WriteLine($"{shape.Name} is a Sphere");
                }
                if (shape is Cube)
                {
                    Console.WriteLine($"{shape.Name} is a Cube");
                }
                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;
                Console.WriteLine($"Volume: {cube2.Volume():N2}");
            }
        }
    }
}