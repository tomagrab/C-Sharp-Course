using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;

            Console.Write("Enter a number: ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.Write("Enter a number: ");
                input = Console.ReadLine();
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}