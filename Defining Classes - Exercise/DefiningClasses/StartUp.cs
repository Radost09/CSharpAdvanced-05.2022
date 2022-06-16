using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {

        static void Main(string[] args)
        {
            Person person1 = new Person();

            Person person2 = new Person(55);

            Person person3 = new Person("Asen", 24);

            Console.WriteLine($"Name: {person1.Name} Age: {person1.Age}");
            Console.WriteLine($"Name: {person2.Name} Age: {person2.Age}");
            Console.WriteLine($"Name: {person3.Name} Age: {person3.Age}");
        }
    }
}