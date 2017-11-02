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
            string input;
            int row;
            int col;

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

                Console.WriteLine("Player X where would you like to move: ");
                input = Console.ReadLine();
                row = Convert.ToInt32(input[0]);

                if(input)
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
        public void update(String[,] board, int row, int col, string player)
        {
            if(row == 1 && col == 1)
            {
                board[3, 3] = player;
            }

            if (row == 1 && col == 2)
            {
                board[3, 5] = player;
            }
            if (row == 1 && col == 3)
            {
                board[3, 7] = player;
            }
            if (row == 2 && col == 1)
            {
                board[5, 3] = player;
            }

            if (row == 2 && col == 2)
            {
                board[5, 5] = player;
            }
            if (row == 2 && col == 3)
            {
                board[5, 7] = player;
            }
            if (row == 3 && col == 1)
            {
                board[7, 3] = player;
            }

            if (row == 3 && col == 2)
            {
                board[7, 5] = player;
            }
            if (row == 3 && col == 3)
            {
                board[7, 7] = player;
            }
        }
        public bool checkRow(String[,] board, int row, char player) 
        {
            if (player == board[row, 1][0] && board[row, 1] == board[row, 2] && board[row, 2] == board[row, 3])
                return true;

            return false;
        }
        public bool checkcol(String[,] board, int col, char player)
        {
            if (player == board[col, 1][0] && board[col, 1] == board[col, 2] && board[col, 2] == board[col, 3])
                return true;

            return false;
        }
        public bool checkdiag(String[,] board, char player)
        {
            if (player == board[1, 1][0] && board[1, 1] == board[2, 2] && board[2, 2] == board[3, 3])
                return true;
            if (player == board[1, 3][0] && board[1, 3] == board[2, 2] && board[2, 2] == board[3, 1])
                return true;

            return false;
        }
    }
}
