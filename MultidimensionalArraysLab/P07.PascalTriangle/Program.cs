using System;
using System.Numerics;

namespace P07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger[][] triangle = new BigInteger[input][];

            for (int row = 0; row < input; row++)
            {
                triangle[row] = new BigInteger[row + 1];
                triangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    triangle[row][col] = 
                        triangle[row - 1][col - 1] +
                        triangle[row - 1][col];
                }
                triangle[row][row] = 1;
            }
            for (int row = 0; row < triangle.Length; row++)
            {
                Console.WriteLine(String.Join(" ", triangle[row]));
            }
        }
    }
}
