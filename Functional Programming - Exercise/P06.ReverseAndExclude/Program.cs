using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int divider = int.Parse(Console.ReadLine());

            Func<int, bool> filter = n => n % divider != 0;
            filter(divider);
           var  printResult = numbers.Where(filter).Reverse().ToList();
            Console.WriteLine(string.Join(" ", printResult)); 
         }
    }
}
