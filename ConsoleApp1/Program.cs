using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] board = new String[4, 4];
            string player;
            string input;
            string restart;
            int row = 0;
            int col = 0;

            board[0, 1] = "  A ";
            board[0, 2] = " B ";
            board[0, 3] = " C ";
            board[1, 0] = "1";
            board[2, 0] = "2";
            board[3, 0] = "3";

            board[1, 1] = " _ ";
            board[1, 2] = " _ ";
            board[1, 3] = " _ ";

            board[2, 1] = " _ ";
            board[2, 2] = " _ ";
            board[2, 3] = " _ ";

            board[3, 1] = " _ ";
            board[3, 2] = " _ ";
            board[3, 3] = " _ ";

            while (true)
            {
                printboard(board);
                player = " X ";
                Console.WriteLine("Player X where would you like to move: ");
                input = Console.ReadLine();
                //row = Convert.ToInt32(input[0]);

                if (input[0] == '1')
                {
                    row = 1;
                }
                if (input[0] == '2')
                {
                    row = 2;
                }
                if (input[0] == '3')
                {
                    row = 3;
                }
                if (input[1] == 'A')
                {
                    col = 1;
                }
                if (input[1] == 'B')
                {
                    col = 2;
                }
                if (input[1] == 'C')
                {
                    col = 3;
                }
                update(board, row, col, player);
                if(checkRow(board, 1, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer X wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if(restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkRow(board, 2, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer X wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkRow(board, 2, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer X wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkcol(board, 1, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer X wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkcol(board, 2, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer X wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkcol(board, 3, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer X wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkdiag(board, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer X wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checktie(board) == true)
                {
                    printboard(board);
                    Console.WriteLine("Tie!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }

                printboard(board);
                player = " O ";
                Console.WriteLine("Player O where would you like to move: ");
                input = Console.ReadLine();
                //row = Convert.ToInt32(input[0]);

                if (input[0] == '1')
                {
                    row = 1;
                }
                if (input[0] == '2')
                {
                    row = 2;
                }
                if (input[0] == '3')
                {
                    row = 3;
                }
                if (input[1] == 'A')
                {
                    col = 1;
                }
                if (input[1] == 'B')
                {
                    col = 2;
                }
                if (input[1] == 'C')
                {
                    col = 3;
                }
                update(board, row, col, player);
                if (checkRow(board, 1, " O ") == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer O wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                }
                if (checkRow(board, 2, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer O wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                }
                if (checkRow(board, 2, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer O wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkcol(board, 1, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer O wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkcol(board, 2, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer O wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkcol(board, 3, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer O wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkdiag(board, player) == true)
                {
                    printboard(board);
                    Console.WriteLine("PLayer O wins!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
                if(checktie(board) == true)
                {
                    printboard(board);
                    Console.WriteLine("Tie!");
                    Console.WriteLine("Do you want to play again?(y/n):");
                    restart = Console.ReadLine();
                    if (restart == "y")
                    {
                        clearboard(board);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public static void printboard(String[,] board)
        {
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void clearboard(String[,] board)
        {
            board[0, 1] = "  A ";
            board[0, 2] = " B ";
            board[0, 3] = " C ";
            board[1, 0] = "1";
            board[2, 0] = "2";
            board[3, 0] = "3";

            board[1, 1] = " _ ";
            board[1, 2] = " _ ";
            board[1, 3] = " _ ";

            board[2, 1] = " _ ";
            board[2, 2] = " _ ";
            board[2, 3] = " _ ";

            board[3, 1] = " _ ";
            board[3, 2] = " _ ";
            board[3, 3] = " _ ";
        }
        public static void update(String[,] board, int row, int col, string player)
        {
            board[row, col] = player;
        }
        public static bool checkRow(String[,] board, int row, string player) 
        {
            if (player == board[row, 1] && board[row, 1] == board[row, 2] && board[row, 2] == board[row, 3])
                return true;

            return false;
        }
        public static bool checkcol(String[,] board, int col, string player)
        {
            if (player == board[col, 1] && board[col, 1] == board[col, 2] && board[col, 2] == board[col, 3])
                return true;

            return false;
        }
        public static bool checkdiag(String[,] board, string player)
        {
            if (player == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] == board[3, 3])
                return true;
            if (player == board[1, 3] && board[1, 3] == board[2, 2] && board[2, 2] == board[3, 1])
                return true;

            return false;
        }
        public static bool checktie(String[,] board)
        {
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    if(board[i, j] == " _ ")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
