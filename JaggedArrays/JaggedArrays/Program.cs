using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main()
        {

            // Jagged array challenge
            // Create a jagged array, which contains 3 "friends arrays", in which two family members are stored
            // Introduce family members from different families to each other

            // Declare jagged array
            string[][] friendsAndFamily = new string[][] {
                new string[] {"Reneta", "Ivon"},
                new string[] {"Gaspar", "Iror"},
                new string[] {"Janequa", "Shan"},
            };

            Console.WriteLine("Introduce family members from different families to each other");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Hello {friendsAndFamily[0][0]}, meet {friendsAndFamily[1][0]}");
        }
    }
}