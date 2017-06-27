using System;
using System.Collections.Generic;
using System.Linq;

namespace Sales_Report
{
    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var salesByTown = new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var town = input[0];
                var product = input[1];
                var price = double.Parse(input[2]);
                var quantity = double.Parse(input[3]);
                var currentSale = new Sale
                {
                    Town = town,
                    Product = product,
                    Price = price,
                    Quantity = quantity
                };

                var currentTown = currentSale.Town;
                var totalMoney = currentSale.Quantity * currentSale.Price;
                if (!salesByTown.ContainsKey(currentTown))
                {
                    salesByTown[currentTown] = 0;
                }

                salesByTown[currentTown] += totalMoney;
            }

            foreach (var town in salesByTown)
            {
                var currentTown = town.Key;
                var currentMoney = town.Value;
                Console.WriteLine($"{currentTown:F2} -> {currentMoney:F2}");
            }
        }
    }
}
