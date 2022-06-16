using System;
using System.Collections.Generic;

namespace P05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> cities =
                new Dictionary<string, Dictionary<string, List<string>>>();
            int citiesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < citiesCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];
                AddCities(cities, continent, country, city);
            }
            PrintCitiesByContinent(cities);
        }

        static void PrintCitiesByContinent(Dictionary<string, Dictionary<string, List<string>>> cities)
        {
            foreach (string continent in cities.Keys)
            {
                Console.WriteLine($"{continent}:");

                foreach (string country in cities[continent].Keys)
                {
                    Console.Write($"  {country} -> ");
                    var allCities = cities[continent][country];
                    Console.WriteLine(string.Join(", ", allCities));
                }
            }
        }

        static void AddCities(Dictionary<string, Dictionary<string, List<string>>> cities,
            string continent, string country, string city)
        {
            if(!cities.ContainsKey(continent))
            {
                cities.Add(continent, new Dictionary<string, List<string>>());
            }
            Dictionary<string, List<string>> countries = cities[continent];
            if(!countries.ContainsKey(country))
            {
                countries.Add(country, new List<string>());
            }
            countries[country].Add(city);
        }
    }
}
