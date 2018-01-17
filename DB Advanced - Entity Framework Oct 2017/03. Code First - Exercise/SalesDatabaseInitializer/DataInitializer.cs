namespace SalesDatabaseInitializer
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using P03_SalesDatabase.Data;
    using P03_SalesDatabase.Data.Models;
    using SalesDatabaseInitializer.Generators;

    public class DataInitializer
    {
        private IList<Customer> customers;
        private IList<Store> stores;
        private IList<Product> products;
        private IList<Sale> sales;

        public DataInitializer()
        {
            this.customers = CustomerGenerator.CustomersGenerator();
            this.stores = StoreGenerator.GenerateStore();
            this.products = ProductGenerator.GenerateProducts();
            this.sales = SalesGenerator.GenerateSales(this.customers, this.products, this.stores);
        }

        public void InitializeDB(SalesContext context)
        {
            this.ResetDatabase(context);

            context.Database.Migrate();

            this.SeedData(context);
        }

        private void ResetDatabase(SalesContext context)
        {
            context.Database.EnsureDeleted();
        }

        private void SeedData(SalesContext context)
        {
            context.AddRange(this.customers);
            context.AddRange(this.stores);
            context.AddRange(this.products);
            context.AddRange(this.sales);
        }
    }
}
