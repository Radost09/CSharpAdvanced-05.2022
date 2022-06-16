using System;
using System.Collections.Generic;

namespace CustomDataStuctures
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var myList = new CustomList();
            myList.Add(5);
            Console.WriteLine(myList[0]);
            
        }
    }
}
