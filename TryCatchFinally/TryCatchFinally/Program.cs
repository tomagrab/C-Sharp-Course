using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Number too large");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Error: Argument is null");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }
        }
    }
}