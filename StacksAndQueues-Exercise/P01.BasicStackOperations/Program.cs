using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] actions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int pushN = actions[0];
            int popS = actions[1];
            int peekX = actions[2];

            List<int> numbersList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < pushN; i++)
            {
                stack.Push(numbersList[i]);
            }
            for (int i = 0; i < popS; i++)
            {
                stack.Pop();
            }
            if(stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if(stack.Contains(peekX))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
