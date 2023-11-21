using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 13, 8, 12, 6, 16 };
            int[] happiness = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            SunIsShining(happiness);
            PrintArray(array);
            Console.WriteLine("Average: {0}", GetAverage(array));
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }

        static double GetAverage(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return (double)sum / array.Length;
        }

        static void SunIsShining(int[] array)
        {
            foreach (int element in array)
            {
                Console.WriteLine(element + 2);
            }
        }
    }
}