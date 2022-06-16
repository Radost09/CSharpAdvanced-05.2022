using System;
using System.Collections.Generic;

namespace P03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            SortedSet<string> unicElements = new SortedSet<string>();

            for (int i = 0; i < inputCount; i++)
            {
                string input = Console.ReadLine();
                string[] chemicals = input.Split(' ');

                foreach (var element in chemicals)
                {
                    unicElements.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", unicElements));
        }
    }
}
