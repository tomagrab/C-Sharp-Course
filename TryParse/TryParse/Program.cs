using System;

namespace TryParse
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
                Console.Write("Please enter a valid number: ");
                input = Console.ReadLine();
            }

            Console.WriteLine(number);
        }
    }
}