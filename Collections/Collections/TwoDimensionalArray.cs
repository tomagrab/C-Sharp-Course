using System;
using System.Collections.Generic;

namespace Collections
{
    class TwoDimensionalArray
    {
        public static void GetTwoDArray()
        {
            string[,] names = new string[3, 2] { { "John", "Smith" }, { "Mary", "Jones" }, { "Sue", "Smith" } };

            for (int i = 0; i < names.GetLength(0); i++)
            {
                for (int j = 0; j < names.GetLength(1); j++)
                {
                    Console.WriteLine($"Name = {names[i, j]}\ni = {i}\nj = {j}\n");
                }
            }
        }
    }
}