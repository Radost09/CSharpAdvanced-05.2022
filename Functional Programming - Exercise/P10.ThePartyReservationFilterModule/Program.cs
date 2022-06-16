using System;
using System.Collections.Generic;
using System.Linq;

namespace P10.ThePartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine().Split(" ").ToList();
            string command = Console.ReadLine();

            while(command != "Print")
            {
                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string filterType = tokens[1];
                string param = tokens[2];
                if (action == "Add filter" || action == "Remove filter")
                {
                    if(filterType == "Starts with")
                    {

                    }
                    else if(filterType == "Ends with")
                    {

                    }
                    else if(filterType == "Length")
                    {

                    }
                    else if(filterType == "Contains")
                    {

                    }
                }
                
            }
        }
    }
}
