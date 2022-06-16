using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> comingPeople = Console.ReadLine().Split(" ").ToList();
            string command = Console.ReadLine();

            while(command != "Party!")
            {
                Predicate<string> predicate = GetPredicate(command);
                if(command.StartsWith("Double"))
                {
                    for (int i = 0; i < comingPeople.Count; i++)
                    {
                        string person = comingPeople[i];
                        if(predicate(person))
                        {
                            comingPeople.Insert(i + 1, person);
                            i++;
                        }
                    }
                }
                else if(command.StartsWith("Remove"))
                {
                    comingPeople.RemoveAll(predicate);
                }

                command = Console.ReadLine();
            }
            if(comingPeople.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", comingPeople)} are going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string command)
        {
            string secondCommand = command.Split()[1];
            string argument = command.Split()[2];

            Predicate<string> predicate = null;

            if(secondCommand == "StartsWith")
            {
                predicate = name => name.StartsWith(argument);
            }
            else if(secondCommand == "EndsWith")
            {
                predicate = name => name.EndsWith(argument);
            }
            else if(secondCommand == "Length")
            {
                predicate = name => name.Length == int.Parse(argument);
            }
            return predicate;
        }
    }
}
