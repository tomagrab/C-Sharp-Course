using System;

namespace NestedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.Write("Please enter your username: ");

            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user");
                Console.Write("Please enter your password: ");
                string password = Console.ReadLine();

                if (password.Equals("12345"))
                {
                    Console.WriteLine("Hi there, admin");
                }
                else
                {
                    Console.WriteLine("Incorrect password, please try again");
                }
            }
            else
            {
                Console.WriteLine("Sorry, you are not allowed to login");
            }

        }
    }
}