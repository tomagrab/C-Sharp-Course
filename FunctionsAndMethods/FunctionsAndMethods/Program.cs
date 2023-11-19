namespace FunctionsAndMethods
{
    class Program
    {
        // A method is a code block that contains a series of statements.
        // A program causes the statements to be executed by calling the method and specifying any required method arguments.
        // In C#, every executed instruction is performed in the context of a method.
        // The main method is the entry point for every C# application and it is called by the common language runtime (CLR) when the program is started.

        // <Access Specifier> <Return Type> <Method Name>(Parameter List)
        // Access Specifier − It defines the visibility of a method. It is optional to use.
        // Return type − A method may return a value. The return type is the data type of the value the method returns. Some methods perform the desired operations without returning a value. In this case, the return type is the keyword void.
        // Method Name − It is a unique identifier and it is case sensitive. It cannot be same as any other identifier declared in the class.
        // Parameter List - Enclosed between parentheses, the parameters are used to pass and receive data from a method. The parameter list refers to the type, order, and number of the parameters of a method. Parameters are optional; that is, a method may contain no parameters.
        static void Main(string[] args)
        {
            // Method body
            WriteSomething();
            WriteSomethingSpecific("Hello from WriteSomethingSpecific()!");

            Console.Write("Enter a first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of {x} and {y} is {Add(x, y)}");
            Console.WriteLine($"The product of {x} and {y} is {Multiply(x, y)}");
            Console.WriteLine($"The quotient of {x} and {y} is {Divide(x, y)}");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Check if the user entered a name
            while (name == "")
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine(Greet(name));
        }

        // Method declaration
        public static void WriteSomething()
        {
            // Method body
            Console.WriteLine("Hello from WriteSomething()!");
        }

        // Method declaration with parameters
        public static void WriteSomethingSpecific(string args)
        {
            // Method body
            Console.WriteLine(args);
        }

        // Method declaration with return type and parameters
        public static int Add(int x, int y)
        {
            // Method body
            return x + y;
        }

        // Method declaration with return type and parameters
        public static int Multiply(int x, int y)
        {
            // Method body
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            // Method body
            return x / y;
        }

        public static string Greet(string name)
        {
            // Method body
            return $"Hello {name}!";
        }
    }
}