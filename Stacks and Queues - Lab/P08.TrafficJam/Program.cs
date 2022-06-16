using System;
using System.Collections.Generic;

namespace P08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPassingCars = int.Parse(Console.ReadLine());
            int totalCarrsPassed = 0;
            Queue<string> queue = new Queue<string>();
            string command;
            while((command = Console.ReadLine()) != "end")
            {
                if(command == "green")
                {
                    for (int i = 0; i < numPassingCars; i++)
                    {
                        if(queue.Count > 0)
                        {
                            string car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            totalCarrsPassed++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{totalCarrsPassed} cars passed the crossroads.");
        }
    }
}
