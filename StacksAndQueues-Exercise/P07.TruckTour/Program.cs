using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gasStations = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < gasStations; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                queue.Enqueue(input);  
            }
            int startIndex = 0;

            while(true)
            {
                bool isValidPump = true;
                int totalLitters = 0;

                foreach (int[] item in queue)
                {
                    int gasAmount = item[0];
                    totalLitters += gasAmount;
                    int distanceToNextGasStation = item[1];

                    if(totalLitters - distanceToNextGasStation < 0)
                    {
                        startIndex++;
                        int[] currentPump = queue.Dequeue();
                        queue.Enqueue(currentPump);
                        isValidPump = false;
                        break;
                    }
                    totalLitters -= distanceToNextGasStation;
                }
                if(isValidPump)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}
