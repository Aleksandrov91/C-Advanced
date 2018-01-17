namespace SalesDatabaseInitializer.Generators
{
    using System;
    using System.Collections.Generic;
    using P03_SalesDatabase.Data.Models;

    internal class SalesGenerator
    {
        private static Random rnd = new Random();

        internal static IList<Sale> GenerateSales(IList<Customer> customers, IList<Product> products, IList<Store> stores)
        {
            IList<Sale> sales = new List<Sale>();

            for (int i = 0; i < 200; i++)
            {
                Sale sale = new Sale()
                {
                    Customer = customers[rnd.Next(0, customers.Count)],
                    Product = products[rnd.Next(0, products.Count)],
                    Store = stores[rnd.Next(0, stores.Count)],
                    Date = RandomDay(i * 4)
                };

                sales.Add(sale);
            }

            return sales;
        }

        private static DateTime RandomDay(int number)
        {
            DateTime start = new DateTime(1995, 1, 1);

            int range = Math.Abs(DateTime.Today.Day - number);

            return start.AddDays(rnd.Next(range));
        }
    }
}
