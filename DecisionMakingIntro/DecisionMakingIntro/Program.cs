using System;

namespace DecisionMakingIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int temperature;

            Console.Write("Enter the temperature: ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out temperature))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.Write("Enter the temperature: ");
                input = Console.ReadLine();
            }

            if (temperature <= 10)
            {
                Console.WriteLine("It's cold!");
            }
            else if (temperature > 20)
            {
                Console.WriteLine("It's mild!");
            }
            else
            {
                Console.WriteLine("It's warm!");
            }
        }
    }
}