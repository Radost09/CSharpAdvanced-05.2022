using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            string guestNumber = Console.ReadLine();

            while (guestNumber != "PARTY")
            {
                if (char.IsDigit(guestNumber[0]))
                {
                    vipGuests.Add(guestNumber);
                }
                else
                {
                    regularGuests.Add(guestNumber);
                }
                guestNumber = Console.ReadLine();
            }
            while(guestNumber != "END")
            {
                if (char.IsDigit(guestNumber[0]))
                {
                    vipGuests.Remove(guestNumber);
                }
                else
                {
                    regularGuests.Remove(guestNumber);
                }
                guestNumber = Console.ReadLine();
            }
            Console.WriteLine(regularGuests.Count + vipGuests.Count);

            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
