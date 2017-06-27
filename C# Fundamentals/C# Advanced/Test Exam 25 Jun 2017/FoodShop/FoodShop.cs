using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FoodShop
{
    public class FoodShop
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            //var statistic = new Dictionary<string, Dictionary<string, long>>();
            var statistics = new List<Shop>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var customer = inputLine[0];
                var product = inputLine[2];
                var price = long.Parse(inputLine[1]);

                statistics.Add(new Shop
                {
                    Customer = customer,
                    Product = product,
                    Price = price
                });

                //if (!statistic.ContainsKey(customer))
                //{
                //    statistic[customer] = new Dictionary<string, long>();
                //}

                //if (!statistic[customer].ContainsKey(product))
                //{
                //    statistic[customer][product] = 0;
                //}

                //statistic[customer][product] += price;
            }

            var group = statistics.GroupBy(x => x.Product);

            foreach (var g in group)
            {
                Console.Write($"{g.Key}: ");

                foreach (var shop in g.GroupBy(d => d.Customer).OrderBy(x => x.Key))
                {
                    Console.Write($"{shop.Key} {shop.Sum(s => s.Price)}, ");
                }
                Console.WriteLine();
            }

            //foreach (var kvp in statistic)
            //{
            //    Console.WriteLine(kvp.Key);
            //    Console.WriteLine(string.Join(" ", kvp.Value.Select(x => $"{x.Key} {x.Value}")));
            //}
        }
    }

    public class Shop
    {
        public string Customer { get; set; }

        public string Product { get; set; }

        public long Price { get; set; }
    }
}
