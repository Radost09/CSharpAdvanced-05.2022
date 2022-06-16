using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            Queue<int> even = new Queue<int>();

            foreach (var item in numbers)
            {
                queue.Enqueue(item);
            }

            while(queue.Count != 0)
            {
                int num = queue.Peek();

                if(num % 2 == 0)
                {
                    even.Enqueue(num);
                    queue.Dequeue();
                }
                else
                {
                    queue.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ", even));
        }
    }
}
