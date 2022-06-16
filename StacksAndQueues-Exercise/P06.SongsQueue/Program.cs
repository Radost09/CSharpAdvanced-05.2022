using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songsQueue = new Queue<string>(songs);
            
            while(songsQueue.Count > 0)
            {
                string command = Console.ReadLine();

                if(command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if(command.Contains("Add"))
                {
                    string song = command.Substring(4);
                    
                    if(songsQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(song);
                    }
                }
                else if(command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }
            Console.WriteLine($"No more songs!");
        }
    }
}
