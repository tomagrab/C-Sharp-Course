using System;
using System.Transactions;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Please enter two numbers to calculate.");

            string firstNumber;
            string secondNumber;
            string result;


            Console.Write("Enter a first number: ");
            firstNumber = Console.ReadLine();

            Console.Write("Enter a second number: ");
            secondNumber = Console.ReadLine();

            while (!IsValidInput(firstNumber) || !IsValidInput(secondNumber))
            {

                if (!IsValidInput(firstNumber))
                {
                    Console.Write("Enter a first number: ");
                    firstNumber = Console.ReadLine();
                }
                else
                {
                    Console.Write("Enter a second number: ");
                    secondNumber = Console.ReadLine();
                }
            }

            Console.WriteLine($"You entered {firstNumber} and {secondNumber}");
            result = Calculate(firstNumber, secondNumber);
            Console.WriteLine("Result: " + result);
        }

        public static string Calculate(string firstNumber, string secondNumber)
        {
            int firstNumberInt = int.Parse(firstNumber);
            int secondNumberInt = int.Parse(secondNumber);

            double firstNumberDouble = double.Parse(firstNumber);
            double secondNumberDouble = double.Parse(secondNumber);

            string operation;


            Console.WriteLine("Add, subtract, multiply, or divide?");
            operation = Console.ReadLine();

            while (!IsValidOperation(operation))
            {
                Console.WriteLine("Please enter a valid operation.");
                operation = Console.ReadLine();
            }

            switch (operation.Trim().ToLower())
            {
                case "add":
                    return Add(firstNumberInt, secondNumberInt).ToString();
                case "subtract":
                    return Subtract(firstNumberInt, secondNumberInt).ToString();
                case "multiply":
                    return Multiply(firstNumberInt, secondNumberInt).ToString();
                case "divide":
                    if (secondNumberDouble == 0)
                    {
                        return "Cannot divide by zero";
                    }
                    return Divide(firstNumberDouble, secondNumberDouble).ToString();
                default:
                    return 0.ToString();
            }
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public static bool IsValidOperation(string operation)
        {
            string op = operation.Trim().ToLower();
            return op == "add" || op == "subtract" || op == "multiply" || op == "divide";
        }

        public static bool IsValidInput(string input)
        {
            string inputTrimmed = input.Trim();
            return int.TryParse(inputTrimmed, out int inputInt);
        }
    }
}