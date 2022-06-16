using System;
using System.Collections.Generic;

namespace P06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string, int>>();
            int numClothes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numClothes; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                Dictionary<string, int> clothes = wardrobe[color];
                string[] clothInput = input[1].Split(",");

                foreach (var cloth in clothInput)
                {
                    if (!clothes.ContainsKey(cloth))
                    {
                        clothes.Add(cloth, 1);
                    }
                    else
                    {
                        clothes[cloth]++;
                    }
                }
            }
            string searchedItem = Console.ReadLine();
            string searchedColor = searchedItem.Split(" ")[0];
            string searchedCloth = searchedItem.Split(" ")[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                Dictionary<string, int> clothes = color.Value;

                foreach (var cloth in clothes)
                {
                    if(cloth.Key == searchedCloth && color.Key == searchedColor)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
