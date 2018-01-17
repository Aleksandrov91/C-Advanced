namespace ProductsShop.Client
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;
    using ProductsShop.Data;
    using ProductsShop.Models;

    public class XmlExercises
    {
        private readonly ProductsShopContext context;

        public XmlExercises(ProductsShopContext context)
        {
            this.context = context;
        }

        public void UsersAndProducts()
        {
            var usersWithSoldProducts = this.context.Users
                .Where(u => u.SoldProducts.Any(p => p.BuyerId != null))
                .OrderByDescending(u => u.SoldProducts.Count)
                .ThenBy(u => u.LastName)
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = u.SoldProducts.Select(sp => new
                    {
                        Name = sp.Name,
                        Price = sp.Price
                    })
                })
                .ToArray();

            XDocument document = new XDocument(new XElement("users", new XAttribute("count", usersWithSoldProducts.Count())));

            foreach (var user in usersWithSoldProducts)
            {
                XAttribute firstName = user.FirstName != null ? new XAttribute("first-name", user.FirstName) : null;
                XAttribute lastName = user.LastName != null ? new XAttribute("last-name", user.LastName) : null;
                XAttribute age = user.Age != null ? new XAttribute("age", user.Age) : null;
                XElement userElement = new XElement("user", firstName, lastName, age);
                XElement soldProducts = new XElement("sold-products", new XAttribute("count", user.SoldProducts.Count()));
                userElement.Add(soldProducts);
                document.Root.Add(userElement);

                foreach (var product in user.SoldProducts)
                {
                    XAttribute productName = new XAttribute("name", product.Name);
                    XAttribute productPrice = new XAttribute("price", product.Price);
                    XElement productElement = new XElement("product", productName, productPrice);
                    soldProducts.Add(productElement);
                }
            }

            document.Save("XmlOutput/UsersAndProducts.xml");
        }

            public void CategoriesByProductsCount()
        {
            var categories = this.context.Categories
                .OrderByDescending(c => c.CategoryProducts.Where(cp => cp.CategoryId == c.CategoryId).Count())
                .Select(c => new
                {
                    Name = c.Name,
                    NumberOfProducts = c.CategoryProducts.Where(cId => cId.CategoryId == c.CategoryId).Count(),
                    AveragePrice = c.CategoryProducts.Select(p => p.Product.Price).Average(),
                    TotalRevenue = c.CategoryProducts.Select(p => p.Product.Price).Sum()
                })
                .ToArray();

            XDocument document = new XDocument(new XElement("categories"));

            foreach (var category in categories)
            {
                XAttribute categoryName = new XAttribute("name", category.Name);
                document.Root.Add(new XElement("category", categoryName,
                    new XElement("products-count", category.NumberOfProducts),
                    new XElement("average-price", category.AveragePrice),
                    new XElement("total-revenue", category.TotalRevenue)));
            }

            document.Save("XmlOutput/CategoriesByProductsCount.xml");
        }

        public void SoldProducts()
        {
            var usersWithProducts = this.context.Users
                .Where(u => u.SoldProducts.Any(sp => sp.BuyerId != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.SoldProducts.Select(sp => new
                    {
                        Name = sp.Name,
                        Price = sp.Price
                    })
                })
                .ToArray();

            XDocument document = new XDocument(new XElement("users"));

            foreach (var user in usersWithProducts)
            {
                XElement soldProducts = new XElement("sold-products");

                foreach (var product in user.SoldProducts)
                {
                    XElement productName = new XElement("name", product.Name == null ? string.Empty : product.Name);
                    XElement productPrice = new XElement("price", product.Price);

                    soldProducts.Add(new XElement("product", productName, productPrice));
                }

                XAttribute firstName = new XAttribute("first-name", user.FirstName == null ? string.Empty : user.FirstName);
                XAttribute lastName = new XAttribute("last-name", user.LastName == null ? string.Empty : user.LastName);
                document.Root.Add(new XElement("user", firstName, lastName), soldProducts);
            }

            document.Save("XmlOutput/SoldProducts.xml");
        }

        public void ProductsInRange()
        {
            var products = this.context.Products
                .Where(p => p.Price >= 1000 && p.Price <= 2000 && p.BuyerId != null)
                .OrderBy(p => p.Price)
                .Select(p => new
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                })
                .ToArray();

            XDocument xdoc = new XDocument();
            xdoc.Add(new XElement("products"));

            foreach (var product in products)
            {
                XAttribute productName = new XAttribute("name", product.Name);
                XAttribute productPrice = new XAttribute("price", product.Price);
                XAttribute productBuyer = new XAttribute("buyer", product.Buyer);

                xdoc.Element("products").Add(new XElement("product", productName, productPrice, productBuyer));                
            }

            xdoc.Save("XMLOutput/ProductsInRange.xml");
        }

        public string ImportUsers()
        {
            string xmlPath = "Files/users.xml";

            string xmlString = File.ReadAllText(xmlPath);

            var xmlDoc = XDocument.Parse(xmlString);

            var elements = xmlDoc.Root.Elements();

            var users = new List<User>();

            foreach (var u in elements)
            {
                string firstName = u.Attribute("firstName")?.Value;
                string lastName = u.Attribute("lastName")?.Value;

                int? age = null;
                if (u.Attribute("age") != null)
                {
                    age = int.Parse(u.Attribute("age").Value);
                }

                User user = new User()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };

                users.Add(user);
            }

            this.context.AddRange(users);
            this.context.SaveChanges();

            return $"{users.Count} has been added to database.";
        }

        public string ImportCategories()
        {
            string xmlPath = "Files/categories.xml";

            string xmlString = File.ReadAllText(xmlPath);

            XDocument xdoc = XDocument.Parse(xmlString);

            IEnumerable<XElement> elements = xdoc.Root.Elements();

            List<Category> categories = new List<Category>();

            foreach (var element in elements)
            {
                string categoryName = element.Element("name")?.Value;

                Category category = new Category
                {
                    Name = categoryName
                };

                categories.Add(category);
            }

            this.context.AddRange(categories);
            this.context.SaveChanges();

            return $"{categories.Count} categories was added to database.";
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
            string productsPath = "Files/products.xml";

            string xmlString = File.ReadAllText(productsPath);

            XDocument xDoc = XDocument.Parse(xmlString);

            IEnumerable<XElement> elements = xDoc.Root.Elements();

            List<Product> products = new List<Product>();

            foreach (var element in elements)
            {
                string productName = element.Element("name")?.Value;
                string stringPrice = element.Element("price")?.Value;

                decimal productPrice = decimal.TryParse(stringPrice, out decimal price) ? price : default(decimal);

                Product product = new Product
                {
                    Name = productName,
                    Price = productPrice,
                };

                products.Add(product);
            }

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

            return $"{products.Count} products was added to database.";
        }
    }
}
