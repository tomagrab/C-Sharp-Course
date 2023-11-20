namespace TicTacToe
{
    class Program
    {

        static char[,] playfield = {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };

        public static void setField()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[0, 0], playfield[0, 1], playfield[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[1, 0], playfield[1, 1], playfield[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[2, 0], playfield[2, 1], playfield[2, 2]);
            Console.WriteLine("     |     |     ");
        }

        internal static void Main(string[] args)
        {
            int player = 2;
            string input = "";
            bool gameOver = false;
            Console.WriteLine("Welcome to Tic Tac Toe!");

            while (!gameOver)
            {

                if (player == 2)
                {
                    player = 1;
                }
                else
                {
                    player = 2;
                }

                setField();
                Console.Write("Please enter a number between 1 and 9: ");
                input = Console.ReadLine();

                if (input.Trim().ToLower().Equals("exit"))
                {
                    break;
                }
                if (!isValidInput(input))
                {
                    continue;
                }

                int position = int.Parse(input);

                switch (player)
                {
                    case 1:
                        switch (position)
                        {
                            case 1:
                                playfield[0, 0] = 'X';
                                break;
                            case 2:
                                playfield[0, 1] = 'X';
                                break;
                            case 3:
                                playfield[0, 2] = 'X';
                                break;
                            case 4:
                                playfield[1, 0] = 'X';
                                break;
                            case 5:
                                playfield[1, 1] = 'X';
                                break;
                            case 6:
                                playfield[1, 2] = 'X';
                                break;
                            case 7:
                                playfield[2, 0] = 'X';
                                break;
                            case 8:
                                playfield[2, 1] = 'X';
                                break;
                            case 9:
                                playfield[2, 2] = 'X';
                                break;
                        }
                        break;
                    case 2:
                        switch (position)
                        {
                            case 1:
                                playfield[0, 0] = 'O';
                                break;
                            case 2:
                                playfield[0, 1] = 'O';
                                break;
                            case 3:
                                playfield[0, 2] = 'O';
                                break;
                            case 4:
                                playfield[1, 0] = 'O';
                                break;
                            case 5:
                                playfield[1, 1] = 'O';
                                break;
                            case 6:
                                playfield[1, 2] = 'O';
                                break;
                            case 7:
                                playfield[2, 0] = 'O';
                                break;
                            case 8:
                                playfield[2, 1] = 'O';
                                break;
                            case 9:
                                playfield[2, 2] = 'O';
                                break;
                        }
                        break;
                }
            }
        }

        internal static bool isValidInput(string input)
        {
            int number;
            bool isNumber = int.TryParse(input, out number);

            if (!isNumber || number < 1 || number > 9)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9.\n");
                return false;
            }

            return true;
        }
    }
}