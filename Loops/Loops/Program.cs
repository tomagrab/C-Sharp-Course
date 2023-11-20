using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(3, 7, 100);
        }

        static void FizzBuzz(int firstNum, int secondNum, int limit) {
            for (int i = 0; i < limit; i++)
            {
                string output = "";
                if (firstNum % i == 0)
                {
                    output += "Fizz";
                } else if (secondNum % i == 0)
                {
                    output += "Buzz";
                } else
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);
            }
        }
    }
}