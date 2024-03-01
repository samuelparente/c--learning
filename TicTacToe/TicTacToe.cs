//Samuel Parente - C# programming exercises

using System;

namespace TicTacToe
{
    class TicTacToe
    {
        static char[,] board = new char[3, 3];
        static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            InitializeBoard();
            bool gameEnded = false;

            while (!gameEnded)
            {
                DisplayBoard();
                Console.WriteLine($"Player {currentPlayer}'s turn.");
                int[] move = GetMove();
                int row = move[0];
                int col = move[1];

                if (IsValidMove(row, col))
                {
                    board[row, col] = currentPlayer;

                    if (CheckWin(row, col))
                    {
                        DisplayBoard();
                        Console.WriteLine($"Player {currentPlayer} wins!");
                        gameEnded = true;
                    }
                    else if (IsBoardFull())
                    {
                        DisplayBoard();
                        Console.WriteLine("It's a draw!");
                        gameEnded = true;
                    }
                    else
                    {
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }
            }
        }

        static void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '-';
                }
            }
        }

        static void DisplayBoard()
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i} ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int[] GetMove()
        {
            Console.WriteLine("Enter row and column (e.g., 0 0):");
            string[] input = Console.ReadLine().Split(' ');
            int row = int.Parse(input[0]);
            int col = int.Parse(input[1]);
            return new int[] { row, col };
        }

        static bool IsValidMove(int row, int col)
        {
            return row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == '-';
        }

        static bool CheckWin(int row, int col)
        {
            return (board[row, 0] == currentPlayer && board[row, 1] == currentPlayer && board[row, 2] == currentPlayer) ||
                   (board[0, col] == currentPlayer && board[1, col] == currentPlayer && board[2, col] == currentPlayer) ||
                   (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                   (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer);
        }

        static bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
