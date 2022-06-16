using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string fullName = personInfo[0] + " " + personInfo[1];
            string adress = personInfo[2];
            string city = personInfo[3];
            Threeuple<string, string, string> firstTuple = 
                new Threeuple<string, string, string>(fullName, adress, city);
            Console.WriteLine(firstTuple);

            string[] nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int littreBeer = int.Parse(nameAndBeer[1]);
            bool drunkOrNot = nameAndBeer[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> secondTuple = 
                new Threeuple<string, int, bool>(name, littreBeer, drunkOrNot);
            Console.WriteLine(secondTuple);
 
            var bankInfo = Console.ReadLine().Split();
            string nameHolder = bankInfo[0];
            double accountBalance = double.Parse(bankInfo[1]);
            string bankName = bankInfo[2];
            Threeuple<string, double, string> thirdTuple = 
                new Threeuple<string, double, string>(nameHolder, accountBalance, bankName);
            Console.WriteLine(thirdTuple);
        //    int numToRead = int.Parse(Console.ReadLine());
        //    List<Box<double>> boxes = new List<Box<double>>();

        //    for (int i = 0; i < numToRead; i++)
        //    {
        //        double text = double.Parse(Console.ReadLine());
        //        boxes.Add(new Box<double>(text));
        //    }
        //    double itemToCompare = double.Parse(Console.ReadLine());
        //    Console.WriteLine(CompareItems(boxes, itemToCompare));
        //}

        //public static double CompareItems<T>(List<Box<T>> boxes, T item)
        //    where T : IComparable<T>
        //{
        //    int count = 0;

        //    foreach (var box in boxes)
        //    {
        //        if(box.CompareTo(item) > 0)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        }
    }
}
