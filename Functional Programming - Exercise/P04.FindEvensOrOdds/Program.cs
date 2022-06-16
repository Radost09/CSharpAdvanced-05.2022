using System;
using System.Collections.Generic;

namespace P04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int startNum = int.Parse(input.Split()[0]);
            int endNum = int.Parse(input.Split()[1]);
            List<int> numbers = new List<int>();

            for (int number = startNum; number <= endNum; number++)
            {
                numbers.Add(number);
            }

            Predicate<int> predicate = null;
            string type = Console.ReadLine();

            if(type == "odd")
            {
                predicate = number => number % 2 != 0;
            }
            else if(type == "even")
            {
                predicate = number => number % 2 == 0;
            }
            Console.WriteLine(string.Join(" ", numbers.FindAll(predicate)));
        }
    }
}
