using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] names = new string[6] { "John", "Mary", "Sue", "Greg", "Yolanda", "Jose" };

            foreach (string name in names)
            {
                Console.WriteLine($"Name = {name}");
            }

            TwoDimensionalArray.GetTwoDArray();
        }
    }
}
