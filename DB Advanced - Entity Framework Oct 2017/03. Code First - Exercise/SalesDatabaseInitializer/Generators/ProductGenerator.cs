namespace SalesDatabaseInitializer.Generators
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using P03_SalesDatabase.Data.Models;
    
    internal class ProductGenerator
    {
        private const string ProductPath = @"../SalesDatabaseInitializer\Data\ProductData.txt";

        private static Random rnd = new Random();
        private static readonly string[] ProductData = File.ReadAllLines(ProductPath);

        internal static IList<Product> GenerateProducts()
        {
            IList<Product> products = new List<Product>();

            for (int i = 0; i < ProductData.Length; i++)
            {
                Product product = new Product()
                {
                    Name = ProductData[i],
                    Quantity = RandomNumberBetween(i, ProductData.Length),
                    Price = (decimal)RandomNumberBetween(i * 2, ProductData.Length * i)
                };

                products.Add(product);
            }

            return products;
        }

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = rnd.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}