using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothesStack = new Stack<int>(clothes);
            int racks = 1;
            int sum = 0;

            while(clothesStack.Any())
            {
                if(sum + clothesStack.Peek() <= rackCapacity)
                {
                    sum += clothesStack.Pop();
                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
