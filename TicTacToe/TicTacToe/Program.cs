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
                player = resetCurrentPlayer(player);
                setField();
                Console.Write($"Player {player}'s turn, please enter a number between 1 and 9: ");
                input = Console.ReadLine();

                if (input.Trim().ToLower().Equals("exit"))
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
                if (!isValidInput(input, player))
                {
                    continue;
                }

                int position = int.Parse(input);
                switch (position)
                {
                    case 1:
                        if (!isValidPosition(0, 0))
                        {
                            player = resetCurrentPlayer(player);
                            continue;
                        }
                        playfield[0, 0] = player == 1 ? 'X' : 'O';
                        break;
                    case 2:
                        if (!isValidPosition(0, 1))
                        {
                            player = resetCurrentPlayer(player);
                            continue;
                        }
                        playfield[0, 1] = player == 1 ? 'X' : 'O';
                        break;
                    case 3:
                        if (!isValidPosition(0, 2))
                        {
                            player = resetCurrentPlayer(player);
                            continue;
                        }
                        playfield[0, 2] = player == 1 ? 'X' : 'O';
                        break;
                    case 4:
                        if (!isValidPosition(1, 0))
                        {
                            player = resetCurrentPlayer(player);
                            continue;
                        }
                        playfield[1, 0] = player == 1 ? 'X' : 'O';
                        break;
                    case 5:
                        if (!isValidPosition(1, 1))
                        {
                            player = resetCurrentPlayer(player);
                            continue;
                        }
                        playfield[1, 1] = player == 1 ? 'X' : 'O';
                        break;
                    case 6:
                        if (!isValidPosition(1, 2))
                        {
                            player = resetCurrentPlayer(player);
                            continue;
                        }
                        playfield[1, 2] = player == 1 ? 'X' : 'O';
                        break;
                    case 7:
                        if (!isValidPosition(2, 0))
                        {
                            player = resetCurrentPlayer(player);
                            continue;
                        }
                        playfield[2, 0] = player == 1 ? 'X' : 'O';
                        break;
                    case 8:
                        if (!isValidPosition(2, 1))
                        {
                            player = resetCurrentPlayer(player);
                            continue;
                        }
                        playfield[2, 1] = player == 1 ? 'X' : 'O';
                        break;
                    case 9:
                        if (!isValidPosition(2, 2))
                        {
                            player = resetCurrentPlayer(player);
                            continue;
                        }
                        playfield[2, 2] = player == 1 ? 'X' : 'O';
                        break;
                }

                if (gameWon(position, position))
                {
                    Console.WriteLine($"Player {player} has won the game!");
                    gameOver = true;
                }
            }
        }

        internal static bool isValidInput(string input, int player)
        {
            int number;
            bool isNumber = int.TryParse(input, out number);

            if (!isNumber || number < 1 || number > 9)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9.\n");
                resetCurrentPlayer(player);
                return false;
            }

            return true;
        }

        internal static bool isValidPosition(int x, int y)
        {
            if (playfield[x, y] == 'X' || playfield[x, y] == 'O')
            {
                Console.WriteLine("This field is already taken. Please choose another one.\n");
                return false;
            }
            else
            {
                return true;
            }
        }

        internal static bool isGameOver()
        {
            return false;
        }

        internal static int resetCurrentPlayer(int player)
        {
            Console.WriteLine($"Player {player} loses his turn.\n");
            return player == 1 ? 2 : 1;
        }

        internal static bool gameWon(int x, int y)
        {
            if (playfield[0, 0] == playfield[0, 1] && playfield[0, 1] == playfield[0, 2])
            {
                return true;
            }
            else if (playfield[1, 0] == playfield[1, 1] && playfield[1, 1] == playfield[1, 2])
            {
                return true;
            }
            else if (playfield[2, 0] == playfield[2, 1] && playfield[2, 1] == playfield[2, 2])
            {
                return true;
            }
            else if (playfield[0, 0] == playfield[1, 0] && playfield[1, 0] == playfield[2, 0])
            {
                return true;
            }
            else if (playfield[0, 1] == playfield[1, 1] && playfield[1, 1] == playfield[2, 1])
            {
                return true;
            }
            else if (playfield[0, 2] == playfield[1, 2] && playfield[1, 2] == playfield[2, 2])
            {
                return true;
            }
            else if (playfield[0, 0] == playfield[1, 1] && playfield[1, 1] == playfield[2, 2])
            {
                return true;
            }
            else if (playfield[0, 2] == playfield[1, 1] && playfield[1, 1] == playfield[2, 0])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}