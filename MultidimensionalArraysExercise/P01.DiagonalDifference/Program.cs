using System;
using System.Linq;

namespace P01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];

            for (int row = 0; row < size; row++)
            {
                matrix[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }
            long firstDiagonal = 0;
            long secondDiagonal = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if(row == col)
                    {
                        firstDiagonal += matrix[row][col];
                    }
                    if(row + col == size - 1)
                    {
                        secondDiagonal += matrix[row][col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
        }
    }
}
