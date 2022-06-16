using System;

namespace P04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string symbols = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currentSymbol = symbols[col];
                    matrix[row, col] = currentSymbol;
                }
            }
            bool isFound = false;
            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        isFound = true;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            if(isFound == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix ");
            }
        }
    }
}
