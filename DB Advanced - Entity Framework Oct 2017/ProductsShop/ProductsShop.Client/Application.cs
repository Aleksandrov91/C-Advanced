namespace ProductsShop.Client
{
    using System;

    using Microsoft.EntityFrameworkCore;
    using ProductsShop.Data;

    public class Application
    {
        public static void Main(string[] args)
        {
            using (ProductsShopContext context = new ProductsShopContext())
            {
                JsonExercises jsonExercises = new JsonExercises(context);
                XmlExercises xmlExercises = new XmlExercises(context);

                //InitializeDB(context);
                //Console.WriteLine(jsonExercises.ImportUsers());
                //Console.WriteLine(jsonExercises.ImportCategories());
                //Console.WriteLine(jsonExercises.ImportProducts());
                //jsonExercises.SetCategories();
                //
                //jsonExercises.GetProductsInRange();
                //jsonExercises.SuccessfullySoldProducts();
                //jsonExercises.CategoriesByProductsCount();
                jsonExercises.UsersAndProducts();

                InitializeDB(context);

                Console.WriteLine(xmlExercises.ImportUsers());
                Console.WriteLine(xmlExercises.ImportCategories());
                Console.WriteLine(xmlExercises.ImportProducts());
                xmlExercises.SetCategories();
                xmlExercises.ProductsInRange();
                xmlExercises.SoldProducts();
                xmlExercises.CategoriesByProductsCount();
                xmlExercises.UsersAndProducts();
            }
        }

        private static void InitializeDB(ProductsShopContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();
        }
    }
}
