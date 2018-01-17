namespace P03_SalesDatabase
{
    using P03_SalesDatabase.Data;
    using P03_SalesDatabase.Data.Models;
    using SalesDatabaseInitializer;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (SalesContext context = new SalesContext())
            {
                //DataInitializer dbInitial = new DataInitializer();

                //dbInitial.InitializeDB(context);

                Product product = new Product()
                {
                    Name = "Wiskey",
                    Quantity = 0.7,
                    Price = 16.99M
                };

                context.Add(product);

                context.SaveChanges();
            }
        }
    }
}
