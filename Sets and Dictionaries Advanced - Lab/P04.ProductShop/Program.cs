using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prices = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Revision")
                {
                    PrintPrices(prices);
                    break;
                }
                string[] commandArgs = command.Split(", ");
                string shop = commandArgs[0];
                string product = commandArgs[1];
                double price = double.Parse(commandArgs[2]);
                AddProduct(prices, shop, product, price);
            }
        }

        static void AddProduct(Dictionary<string, Dictionary<string, double>> prices,
            string shop, string product, double price)
        {
            if(!prices.ContainsKey(shop))
            {
                prices.Add(shop, new Dictionary<string, double>());
                
            }
            prices[shop][product] = price;

        }

        static void PrintPrices(Dictionary<string, Dictionary<string, double>> prices)
        {
            foreach (var shopAndProduct in prices.OrderBy(sp => sp.Key))
            {
                string shopName = shopAndProduct.Key;
                Console.WriteLine($"{shopName}-> ");
                var products = shopAndProduct.Value;

                foreach (var productAndPrice in products)
                {
                    Console.WriteLine($"Product: {productAndPrice.Key}, Price: {productAndPrice.Value}");
                }
            }
        }
    }
}
