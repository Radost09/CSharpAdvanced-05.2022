using System;
using System.Collections.Generic;

namespace P01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int namesCount = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < namesCount; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
