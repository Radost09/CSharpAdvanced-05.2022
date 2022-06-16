using System;
using System.Collections.Generic;

namespace P05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            string text = Console.ReadLine();

            foreach (var ch in text)
            {
                if(symbols.ContainsKey(ch))
                {
                    symbols[ch]++;
                }
                else
                {
                    symbols.Add(ch, 1);
                }
            }
            foreach (var pair in symbols)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
