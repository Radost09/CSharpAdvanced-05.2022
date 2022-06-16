using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = Console.ReadLine();
            Func<List<int>, List<int>> func = null;
            Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));
            while (command != "end")
            {
                switch(command)
                {
                    case "add":
                        func = list => list.Select(number => number += 1).ToList();
                        numbers = func(numbers);
                        break;
                    case "multiply":
                        func = list => list.Select(number => number *= 2).ToList();
                        numbers = func(numbers);
                        break;
                    case "subtract":
                        func = list => list.Select(number => number -= 1).ToList();
                        numbers = func(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
