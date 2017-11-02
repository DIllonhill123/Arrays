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
            String[,] board = new string[8, 8];
            string input;

            board[0, 3] = " A ";
            board[0, 5] = " B ";
            board[0, 7] = " C ";
            board[3, 0] = "1";
            board[5, 0] = "2";
            board[7, 0] = "3";
            board[1, 3] = "-";
            board[1, 5] = "-";
            board[1, 7] = "-";
            board[1, 2] = "+-";
            board[1, 4] = "-+-";
            board[1, 6] = "-+";
            board[2, 2] = "+-";
            board[2, 4] = "-+-";
            board[2, 6] = "-+";




        }
        public void printboard(String[,] board)
        {
            for(int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board.Length; j++)
                {
                    Console.Write(board[i, j]);
                    Console.WriteLine();
                }
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
            if (player == board[row, 3][0] && board[row, 3] == board[row, 5] && board[row, 5] == board[row, 7])
                return true;

            return false;
        }
        public bool checkcol(String[,] board, int col, char player)
        {
            if (player == board[col, 3][0] && board[col, 3] == board[col, 5] && board[col, 5] == board[col, 7])
                return true;

            return false;
        }
        public bool checkdiag(String[,] board, char player)
        {
            if (player == board[3, 3][0] && board[3, 3] == board[5, 5] && board[5, 5] == board[7, 7])
                return true;
            if (player == board[3, 7][0] && board[3, 7] == board[5, 5] && board[5, 5] == board[7, 3])
                return true;

            return false;
        }
    }
}
