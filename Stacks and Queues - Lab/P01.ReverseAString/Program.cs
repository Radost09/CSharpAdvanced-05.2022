using System;
using System.Collections;
using System.Collections.Generic;

namespace Stacks_and_Queues___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var ch in str)
            {
                stack.Push(ch);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
