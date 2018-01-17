namespace ProductsShop.Client
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Newtonsoft.Json;
    using ProductsShop.Data;
    using ProductsShop.Models;

    public class JsonExercises
    {
        private readonly ProductsShopContext context;

        public JsonExercises(ProductsShopContext context)
        {
            this.context = context;
        }

        public void UsersAndProducts()
        {
            var usersWithSoldProducts = this.context.Users
                .Where(u => u.SoldProducts.Any(p => p.BuyerId != null))
                .OrderByDescending(u => u.SoldProducts.Count)
                .ThenBy(u => u.LastName)
                .Select(up => new
                {
                    UsersCount = this.context.Users
                                     .Where(uc => uc.SoldProducts.Any(p => p.BuyerId != null)).Count(),
                    Users = this.context.Users
                                .Where(u => u.SoldProducts.Any(p => p.BuyerId != null))
                                .OrderByDescending(u => u.SoldProducts.Count)
                                .ThenBy(u => u.LastName)
                                .Select(u => new
                                {
                                    FirstName = u.FirstName,
                                    LastName = u.LastName,
                                    Age = u.Age,
                                    SoldProducts = u.SoldProducts.Select(p => new
                                    {
                                        Count = u.SoldProducts.Count,
                                        Products = u.SoldProducts.Select(sp => new
                                        {
                                            Name = sp.Name,
                                            Predicate = sp.Price
                                        }).ToArray()
                                    }).ToArray()
                                }).ToArray()
                }).ToArray();

            string jsonString = JsonConvert.SerializeObject(usersWithSoldProducts, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });

            File.WriteAllText("JsonOutput/UsersAndProducts.json", jsonString);
        }

        public void CategoriesByProductsCount()
        {
            var categories = this.context.Categories
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    Name = c.Name,
                    ProductsCount = c.CategoryProducts.Count,
                    AvveragePrice = c.CategoryProducts.Select(p => p.Product.Price).Average(),
                    TotalRevenue = c.CategoryProducts.Select(p => p.Product.Price).Sum()
                })
                .ToArray();

            string jsonString = JsonConvert.SerializeObject(categories, Formatting.Indented);

            File.WriteAllText("JsonOutput/CategoriesByProductsCount.json", jsonString);
        }

        public void SuccessfullySoldProducts()
        {
            var usersWithSoldProduct = this.context.Users
                .Where(u => u.SoldProducts.Any(p => p.BuyerId != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.SoldProducts.Select(p => new
                    {
                        Name = p.Name,
                        Price = p.Price,
                        BuyerFirstName = p.Buyer.FirstName,
                        BuyerLastName = p.Buyer.LastName
                    })
                })
                .ToArray();

            string jsonString = JsonConvert.SerializeObject(usersWithSoldProduct, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });

            File.WriteAllText("JsonOutput/SuccessfullySoldProducts.json", jsonString);
        }

        public void GetProductsInRange()
        {
            var products = this.context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new
                {
                    Name = p.Name,
                    Price = p.Price,
                    Seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                })
                .ToArray();

            string jsonString = JsonConvert.SerializeObject(products, Formatting.Indented);

            File.WriteAllText("JsonOutput/GetProductsInRange.json", jsonString);
        }

        public void SetCategories()
        {
            int[] productIds = this.context.Products
                .Select(p => p.ProductId)
                .ToArray();

            int[] categoriesIds = this.context.Categories
                .Select(c => c.CategoryId)
                .ToArray();

            List<CategoryProduct> categoryProducts = new List<CategoryProduct>();

            Random rnd = new Random();

            foreach (var id in productIds)
            {
                for (int i = 0; i < 3; i++)
                {
                    int categoryIndex = rnd.Next(0, categoriesIds.Length);

                    while (categoryProducts.Any(cp => cp.CategoryId == categoriesIds[categoryIndex] &&
                                                cp.ProductId == id))
                    {
                        categoryIndex = rnd.Next(0, categoriesIds.Length);
                    }

                    var categoryProduct = new CategoryProduct
                    {
                        CategoryId = categoriesIds[categoryIndex],
                        ProductId = id
                    };

                    categoryProducts.Add(categoryProduct);
                }
            }

            this.context.CategoryProducts.AddRange(categoryProducts);
            this.context.SaveChanges();
        }

        public string ImportProducts()
        {
            string productsPath = "Files/products.json";

            Product[] products = this.ImportJson<Product>(productsPath);

            Random rnd = new Random();

            int[] userIds = this.context.Users.Select(u => u.UserId).ToArray();

            foreach (var product in products)
            {
                int sellerIndex = rnd.Next(0, userIds.Length);
                int sellerId = userIds[sellerIndex];

                int? buyerId = sellerId;
                while (buyerId == sellerId)
                {
                    int buyerIndex = rnd.Next(0, userIds.Length);
                    buyerId = userIds[buyerIndex];
                }

                if (buyerId - sellerId < 7 && buyerId - sellerId > 0)
                {
                    buyerId = null;
                }

                product.BuyerId = buyerId;
                product.SellerId = sellerId;
            }

            this.context.Products.AddRange(products);
            this.context.SaveChanges();

            return $"{products.Length} products was added to database.";
        }

        public string ImportCategories()
        {
            string categoriesPath = "Files/categories.json";

            Category[] categories = this.ImportJson<Category>(categoriesPath);

            this.context.Categories.AddRange(categories);
            this.context.SaveChanges();

            return $"{categories.Length} categories was added to database.";
        }

        public string ImportUsers()
        {
            string usersPath = "Files/users.json";
            User[] users = this.ImportJson<User>(usersPath);

            this.context.Users.AddRange(users);
            this.context.SaveChanges();

            return $"{users.Length} users was added to database.";
        }

        private T[] ImportJson<T>(string path)
        {
            string jsonString = File.ReadAllText(path);

            T[] objects = JsonConvert.DeserializeObject<T[]>(jsonString);

            return objects;
        }
    }
}
