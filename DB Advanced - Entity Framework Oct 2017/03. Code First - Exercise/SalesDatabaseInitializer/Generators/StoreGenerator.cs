namespace SalesDatabaseInitializer.Generators
{
    using System;
    using System.Collections.Generic;
    using P03_SalesDatabase.Data.Models;

    internal class StoreGenerator
    {
        private static readonly string[] StoresData = new[] { "Ikea", "Kaufland", "Lidl", "Metro", "Fantastico", "CBA", "Makao", "My Market", "Стиви", "Аванти" };

        private static Random rnd = new Random();

        internal static IList<Store> GenerateStore()
        {
            IList<Store> stores = new List<Store>();

            for (int i = 0; i < StoresData.Length; i++)
            {
                Store store = new Store()
                {
                    Name = StoresData[i]
                };

                stores.Add(store);
            }

            return stores;
        }
    }
}
