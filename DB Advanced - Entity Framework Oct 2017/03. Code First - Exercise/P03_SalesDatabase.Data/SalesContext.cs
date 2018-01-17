namespace P03_SalesDatabase.Data
{
    using Microsoft.EntityFrameworkCore;
    using P03_SalesDatabase.Data.Models;
    using P03_SalesDatabase.Data.Models.Configurations;

    public class SalesContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);

            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CustomerConfiguration());

            builder.ApplyConfiguration(new ProductConfiguration());

            builder.ApplyConfiguration(new StoreConfiguration());

            builder.ApplyConfiguration(new SaleConfiguration());
        }
    }
}
