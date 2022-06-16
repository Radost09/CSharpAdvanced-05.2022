using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVAT = x => x * 1.20m;

            string input = Console.ReadLine();
            string[] tokens = input.Split(", ");
            decimal[] numbers = tokens.Select(decimal.Parse).ToArray();
            List<decimal> numbersWithVAT = numbers.Select(addVAT).ToList();

            numbersWithVAT.ForEach(x => Console.WriteLine("{0:f2}", x));
        }
    }
}
