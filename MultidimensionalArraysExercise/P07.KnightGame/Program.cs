using System;

namespace P07.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] board = new char[size, size];

            FillTheBoard(board);

            int removeKnightCount = 0;

            while(true)
            {
                int maxAttack = 0;
                int rowAttackIndex = 0;
                int colAttackIndex = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        if (board[row, col] == '0')
                        {
                            continue;
                        }

                        int currentAttack = 0;
                        if(IsInBoardRange(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                        {
                            currentAttack++;
                        }
                        if(IsInBoardRange(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                        {
                            currentAttack++;
                        }
                        if(IsInBoardRange(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                        {
                            currentAttack++;
                        }
                        if(IsInBoardRange(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                        {
                            currentAttack++;
                        }
                        if(IsInBoardRange(board, row - 1, col -2) && board[row - 1, col - 2] == 'K')
                        {
                            currentAttack++;
                        }
                        if(IsInBoardRange(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            currentAttack++;
                        }
                        if(IsInBoardRange(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                        {
                            currentAttack++;
                        }
                        if(IsInBoardRange(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                        {
                            currentAttack++;
                        }
                        if(currentAttack > maxAttack)
                        {
                            maxAttack = currentAttack;
                            rowAttackIndex = row;
                            colAttackIndex = col;
                        }
                    }
                }
                if(maxAttack > 0)
                {
                    board[rowAttackIndex, colAttackIndex] = '0';
                    removeKnightCount++;
                }
                else
                {
                    Console.WriteLine(removeKnightCount);
                    break;
                }
            }
        }
        static bool IsInBoardRange(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0)
                && col >= 0 && col < board.GetLength(1);
        }

        static void FillTheBoard(char[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                string column = Console.ReadLine();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = column[col];
                }
            }
        }
    }
}
