﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FilterByAge
{
    internal class Program
    {
        class Person
        {
            //public Person(string name, int age)
            //{
            //    this.Name = name;
            //    this.Age = age;
            //}
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            List<Person> people = ReadPeople();

            string condition = Console.ReadLine();
            int ageThershold = int.Parse(Console.ReadLine());
            Func<Person, bool> filter = CreatePersonFilter(condition, ageThershold);

            List<Person> matchingPeople = people.Where(filter).ToList();

            string formatString = Console.ReadLine();
            Action<Person> printPerson = CreatePersonPrinter(formatString);

            PrintPeople(matchingPeople, printPerson);
        }

        static List<Person> ReadPeople()
        {
            int numOfPeopple = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();
            for (int i = 0; i < numOfPeopple; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                people.Add(new Person { Name = name, Age = age });
            }
            return people;
        }

        static Func<Person, bool> CreatePersonFilter(string condition, int ageThreshold)
        {
            if(condition == "older")
            {
                return p => p.Age >= ageThreshold;
            }
            if(condition == "younger")
            {
                return p => p.Age < ageThreshold;
            }
            throw new ArgumentException ($"Invalid filter: {condition} {ageThreshold}");
        }
 
        static Action<Person> CreatePersonPrinter(string format)
        {
            if (format == "name age")
            {
                return (Person p) => Console.WriteLine($"{p.Name} - {p.Age}");
            }
            if (format == "name")
            {
                return (Person p) => Console.WriteLine($"{p.Name}");
            }
            if (format == "age")
            {
                return (Person p) => Console.WriteLine($"{p.Age}");
            }
            throw new ArgumentException("Invalid format: " + format);
        }

        static void PrintPeople(List<Person> people, Action<Person> printPerson)
        {
            foreach (var person in people)
            {
                printPerson(person);
            }
        }
    }
}
