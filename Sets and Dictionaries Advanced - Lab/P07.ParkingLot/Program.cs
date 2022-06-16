using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();
            string input = Console.ReadLine();
            while(input != "END")
            {
                string[] inputParams = Regex.Split(input, ", ");
                string income = inputParams[0];
                string outcome = inputParams[1];

                if(income == "IN")
                {
                    parking.Add(outcome);
                }
                if(income == "OUT")
                {
                    parking.Remove(outcome);
                }
                
                input = Console.ReadLine();
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            foreach (var item in parking)
            {
                Console.WriteLine(item);
            }
        }
    }
}
