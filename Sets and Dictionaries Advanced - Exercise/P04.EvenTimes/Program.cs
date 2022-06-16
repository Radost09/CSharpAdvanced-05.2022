using System;
using System.Collections.Generic;

namespace P04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            Dictionary<int, int> evenTimes = new Dictionary<int, int>();
            for (int i = 1; i <= numCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(!evenTimes.ContainsKey(number))
                {
                    evenTimes.Add(number, 1);
                }
                else
                {
                    evenTimes[number]++;
                }
            }
            foreach (var load in evenTimes)
            {
                if(load.Value % 2 == 0)
                {
                    Console.WriteLine(load.Key);
                }
            }
        }
    }
}
