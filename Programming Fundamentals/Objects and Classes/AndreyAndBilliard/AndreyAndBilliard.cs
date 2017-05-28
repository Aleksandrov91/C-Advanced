using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
    public class AndreyAndBilliard
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var products = new Dictionary<string, decimal>();
            var wantedProducts = new List<Customer>();
            for (int i = 0; i < n; i++)
            {
                var lineOfProducts = Console.ReadLine().Split('-');
                var productName = lineOfProducts[0];
                var productPrice = decimal.Parse(lineOfProducts[1]);
                if (!products.ContainsKey(productName))
                {
                    products[productName] = 0;
                }

                products[productName] = productPrice;
            }

            var clients = Console.ReadLine();
            while (clients != "end of clients")
            {
                var clientsLine = clients.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = clientsLine[0];
                var product = clientsLine[1];
                var quantity = int.Parse(clientsLine[2]);
                if (!products.ContainsKey(product))
                {
                    clients = Console.ReadLine();
                    continue;
                }

                if (wantedProducts.Any(c => c.Name == name))
                {
                    var currentClient = wantedProducts.First(c => c.Name == name);
                    if (!currentClient.ClientProducts.ContainsKey(product))
                    {
                        currentClient.ClientProducts.Add(product, quantity);
                    }
                    else
                    {
                        currentClient.ClientProducts[product] += quantity;
                    }
                    currentClient.Bill += quantity * products[product];
                }
                else
                {
                    var currentClient = new Customer
                    {
                        Name = name,
                        ClientProducts = new Dictionary<string, int>()
                    };
                    currentClient.ClientProducts.Add(product, quantity);
                    wantedProducts.Add(currentClient);
                    currentClient.Bill = quantity * products[product];
                }

                clients = Console.ReadLine();
            }

            var totalBill = 0m;
            foreach (var client in wantedProducts.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{client.Name}");
                var clientProduct = client.ClientProducts;
                foreach (var product in clientProduct)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }

                Console.WriteLine($"Bill: {client.Bill:F2}");
                totalBill += client.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}
