using System;
using System.Linq;

namespace P03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ').Select(number => int.Parse(number))
                .OrderByDescending(number => number)
                .Take(3)
                .ToArray();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
