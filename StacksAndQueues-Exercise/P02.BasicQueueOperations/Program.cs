using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] actions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int enqueueN = actions[0];
            int dequeueS = actions[1];
            int peekX = actions[2];
            List<int> numbersList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < enqueueN; i++)
            {
                queue.Enqueue(numbersList[i]);
            }
            for (int i = 0; i < dequeueS; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(peekX))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
