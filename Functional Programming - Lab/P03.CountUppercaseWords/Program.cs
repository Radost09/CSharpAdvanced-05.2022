using System;
using System.Linq;

namespace P03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();
            Func<string, bool> isFirstLetterCapital = x => x.Length > 0 && char.IsUpper(x[0]);

            Console.WriteLine(string.Join("\r\n", Console.ReadLine()
                .Split(" ").Where(isFirstLetterCapital).ToArray()));

        }
    }
}
