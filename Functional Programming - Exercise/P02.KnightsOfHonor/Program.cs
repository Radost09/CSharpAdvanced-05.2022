using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ").ToList();

            Action<string> print = name => Console.WriteLine("Sir" + " " + name);

            names.ForEach(print);
        }
    }
}
