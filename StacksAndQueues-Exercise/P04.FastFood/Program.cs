using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            List<int> orderQuantity = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Queue<int> ordersQueue = new Queue<int>(orderQuantity);
            Console.WriteLine(ordersQueue.Max());

            int ordersCount = ordersQueue.Count;

            for (int order = 1; order <= ordersCount; order++)
            {
                if(foodQuantity >= ordersQueue.Peek())
                {
                    foodQuantity -= ordersQueue.Peek();
                    ordersQueue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if(ordersQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(" ", ordersQueue));
            }
        }
    }
}
