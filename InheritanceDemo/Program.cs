using InheritanceDemo.Models;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Derek Bananas");

            Console.WriteLine(post1.ToString());
        }
    }
}