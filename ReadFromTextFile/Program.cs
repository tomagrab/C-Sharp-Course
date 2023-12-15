using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        /* 
            * Create a class Program with the Main method with code that will read from the input.txt line by line;
            * If one of the lines contains "split" find it;
            * And after, split it (use the split method from the string class)
            * Take the return from the split and write the element with index 4 into the output.txt ;
            * You have to add a space between each element to make it readable;
         */

        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            string output = "";
            foreach (string line in lines)
            {
                if (line.Contains("split"))
                {
                    string[] split = line.Split(" ");
                    output += split[4] + " ";
                }
            }
            File.WriteAllText("output.txt", output);
        }
    }
}