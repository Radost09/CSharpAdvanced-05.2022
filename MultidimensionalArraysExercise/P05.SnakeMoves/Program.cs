﻿using System;
using System.Linq;

namespace P05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine()
                .Split(" ")
                .ToArray();
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            char[,] matrix = new char[rows, cols];
            string snake = Console.ReadLine();
            int index = 0;

            for (int row = 0; row < rows; row++)
            {
                if(row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[index];
                        index++;

                        if(index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[index];
                        index++;

                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
