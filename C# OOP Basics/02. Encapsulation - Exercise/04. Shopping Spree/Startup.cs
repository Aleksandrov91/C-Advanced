namespace _04.Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var personsNumber = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var persons = new List<Person>();

            foreach (var person in personsNumber)
            {
                var personData = person.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    persons.Add(new Person(personData[0], decimal.Parse(personData[1])));
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }

            var productsNumber = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var products = new List<Product>();

            foreach (var product in productsNumber)
            {
                var productData = product.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    products.Add(new Product(productData[0], decimal.Parse(productData[1])));
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }

            var orders = Console.ReadLine();

            while (orders != "END")
            {
                var ordersData = orders.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var buyer = persons.Where(p => p.Name == ordersData[0]).FirstOrDefault();
                var product = products.Where(p => p.Name == ordersData[1]).FirstOrDefault();
                if (buyer.BuyProduct(product))
                {
                    Console.WriteLine($"{buyer.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{buyer.Name} can\'t afford {product.Name}");
                }

                orders = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                Console.Write($"{person.Name} - ");
                if (person.Bag.Count == 0)
                {
                    Console.WriteLine("Nothing bought");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", person.Bag.Select(p => $"{p.Name}")));
                }
            }
        }
    }
}