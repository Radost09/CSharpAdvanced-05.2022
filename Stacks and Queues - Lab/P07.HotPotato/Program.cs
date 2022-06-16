﻿using System;
using System.Collections.Generic;

namespace P07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(players);

            while(queue.Count > 1)
            {
                for (int i = 1; i <= n - 1; i++)
                {
                    string player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                string lostPlayer = queue.Dequeue();
                Console.WriteLine($"Removed {lostPlayer}");
            }
            string lastPlayer = queue.Dequeue();
            Console.WriteLine($"Last is {lastPlayer}");
        }
    }
}
