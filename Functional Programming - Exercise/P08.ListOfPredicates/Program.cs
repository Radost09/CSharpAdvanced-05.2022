using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> numbers = new List<int>();

            for (int number = 1; number <= endOfRange; number++)
            {
                numbers.Add(number);
            }

            List<int> printNumbers = new List<int>();
            foreach (var number in numbers)
            {
                bool isDivisible = true;

                foreach (var divider in dividers)
                {
                    Predicate<int> divisible = number => number % divider == 0;

                    if (!divisible(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    printNumbers.Add(number);
                }
            }
            Console.WriteLine(String.Join(" ", printNumbers));
        }
    }
}
