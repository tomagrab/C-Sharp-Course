using System;

namespace LoopsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;
            float average = 0.00f;

            while (true)
            {
                Console.Write("Enter a number between 0 and 20 or -1 to exit: ");
                input = Console.ReadLine();


                if (input.Equals("-1"))
                {
                    break;
                }

                if (int.TryParse(input, out currentNumber) && currentNumber >= 0 && currentNumber <= 20)
                {
                    total += currentNumber;
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
            }

            if (count > 0)
            {
                average = (float)total / count;
                Console.WriteLine("The average of the numbers you entered is: " + average);
            }
            else
            {
                Console.WriteLine("You didn't enter any numbers.");
            }
        }
    }
}