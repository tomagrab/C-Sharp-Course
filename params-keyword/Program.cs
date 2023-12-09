using ParamsExample.Models;

namespace ParamsExample
{
    class Program
    {
        private static List<User> users = new List<User>();
        private static User currentUser = null;
        private static bool loggedIn = false;
        private static bool session = true;
        static void Main(string[] args)
        {
            while (session)
            {
                Console.Clear();
                DisplayHeader("Welcome to the bank!");
                while (currentUser == null)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the bank! Do you have an account? (yes/no)");
                    string response = Console.ReadLine().ToLower();

                    switch (response)
                    {
                        case "y":
                        case "ye":
                        case "yes":
                        case "yea":
                        case "yeas":
                        case "yeah":
                        case "yep":
                        case "yup":
                        case "yus":
                        case "yis":
                        case "yiss":
                        case "yass":
                            LoginUser();
                            break;
                        case "n":
                        case "no":
                        case "nah":
                        case "nope":
                        case "naw":
                        case "nay":
                        case "nix":
                            RegisterUser();
                            break;
                        case "exit":
                        case "quit":
                        case "q":
                            session = false;
                            break;
                        default:
                            Console.WriteLine("Invalid response. Please try again.");
                            break;
                    }
                }

                while (loggedIn)
                {
                    Console.Clear();
                    DisplayHeader($"Banking Menu - {currentUser.Name}");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Get Balance");
                    Console.WriteLine("4. Logout");
                    Console.WriteLine("Type 'exit' to quit.");
                    string response = Console.ReadLine();

                    switch (response)
                    {
                        case "1":
                            Deposit();
                            break;
                        case "2":
                            Withdraw();
                            break;
                        case "3":
                            GetBalance();
                            break;
                        case "4":
                            LogoutUser();
                            break;
                        case "exit":
                        case "quit":
                        case "q":
                            Quit();
                            break;
                        default:
                            Console.WriteLine("Invalid response. Please try again.");
                            break;
                    }
                }
            }
        }

        public static bool RegisterUser()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your email address?");
            string email = Console.ReadLine();
            Console.WriteLine("What is your password?");
            string password = ReadPassword();

            User newUser = new User(name, email, password);
            users.Add(newUser);
            currentUser = newUser;

            Console.WriteLine($"Welcome, {currentUser.Name}!");
            return loggedIn = true;
        }
        public static void LoginUser()
        {
            Console.WriteLine("Enter your email address:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            currentUser = users.Find(user => user.ValidateUser(email, password));

            if (currentUser == null)
            {
                Console.WriteLine("Invalid email or password. Please try again.");
                loggedIn = false;
            }
            else
            {
                Console.WriteLine($"Welcome back, {currentUser.Name}!");
                loggedIn = true;
            }
        }
        public static void Quit()
        {
            Console.WriteLine("Goodbye!");

            if (loggedIn)
            {
                LogoutUser();
            }

            session = false;
        }
        public static void LogoutUser()
        {
            Console.WriteLine("You have been logged out.");
            currentUser = null;
            loggedIn = false;
        }
        public static void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            double amount = Convert.ToDouble(Console.ReadLine());
            currentUser.Deposit(amount);
            Console.WriteLine($"Your new balance is {currentUser.GetBalance()}");
            PauseScreen();
        }
        public static void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            double amount = Convert.ToDouble(Console.ReadLine());
            currentUser.Withdraw(amount);
            Console.WriteLine($"Your new balance is {currentUser.GetBalance()}");
            PauseScreen();
        }
        public static void GetBalance()
        {
            Console.WriteLine($"Your balance is {currentUser.GetBalance():C}");
            PauseScreen();
        }
        public static void DisplayHeader(string title)
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine(title);
            Console.WriteLine(new string('=', 30));
        }
        public static void PauseScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            // add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }
    }
}