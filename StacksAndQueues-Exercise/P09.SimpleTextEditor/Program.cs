using System;
using System.Collections.Generic;
using System.Text;

namespace P09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOperations = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> passedCondition = new Stack<string>();

            for (int i = 1; i <= numOperations; i++)
            {
                string command = Console.ReadLine();

                if(command.StartsWith("1"))
                {
                    passedCondition.Push(text.ToString());
                    string textToAdd = command.Split(' ')[1];
                    text.Append(textToAdd);
                }
                else if(command.StartsWith("2"))
                {
                    passedCondition.Push(text.ToString());
                    int count = int.Parse(command.Split(' ')[1]);
                    text.Remove(text.Length - count, count);
                }
                else if(command.StartsWith("3"))
                {
                    int index = int.Parse(command.Split(' ')[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if(command.StartsWith("4"))
                {
                    text = new StringBuilder(passedCondition.Pop());
                }
            }
        }
    }
}
