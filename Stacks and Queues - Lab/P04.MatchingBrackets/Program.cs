using System;
using System.Collections.Generic;

namespace P04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expresion = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expresion.Length; i++)
            {
                char ch = expresion[i];

                if(ch == '(')
                {
                    stack.Push(i);
                }
                else if(ch == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string subExpresion = expresion.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(subExpresion);
                }
            }
        }
    }
}
