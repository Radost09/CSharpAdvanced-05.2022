using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            string command = Console.ReadLine().ToLower();

            while(command != "end")
            {
                string[] cmdArgs = command.Split(' ');
                string action = cmdArgs[0];
                
                if(action == "add")
                {
                    int n1 = int.Parse(cmdArgs[1]);
                    int n2 = int.Parse(cmdArgs[2]);
                    stack.Push(n1);
                    stack.Push(n2);
                }
                else if(action == "remove")
                {
                    int count = int.Parse(cmdArgs[1]);
                    if(stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                   
                }
                command = Console.ReadLine().ToLower();
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
