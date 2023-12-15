using System;

/* 
    * Complete the Run Method with code that will:
    * Parse the line into int if it is possible. Otherwise, or if the value is not in the range between 0 and 180, display "Check the input!" on the new line and return;
    * if the parsing was successful, calculate and print:
    * Cosine of this angle in the format "Cos = X", where X is the value;
    * Sine of the angle in the format "Sin = X", where X is the value;
    * Tangent of the angle in the format "Tg = X", where X is the value;
    * Hint: All of those methods expect us to provide radians as input. In order to convert the angle to radians, use the method ConvertToRadians.
 */

namespace Coding.Exercise
{

    public class Exercise
    {
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static void Run(string line)
        {
            int angle;
            if (Int32.TryParse(line, out angle) && angle >= 0 && angle <= 180)
            {
                Console.WriteLine("Cos = {0}", Math.Cos(ConvertToRadians(angle)));
                Console.WriteLine("Sin = {0}", Math.Sin(ConvertToRadians(angle)));
                Console.WriteLine("Tg = {0}", Math.Tan(ConvertToRadians(angle)));
            }
            else
            {
                Console.WriteLine("Check the input!");
                return;
            }
        }
    }
}
