using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ").ToList();
            
            Predicate<string> filter = name => name.Length <= nameLength;
            Console.WriteLine(string.Join("\r\n", names.Where(x => filter(x))));
        }
    }
}
