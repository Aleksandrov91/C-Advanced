using System;
using System.Globalization;

namespace Softuni_Coffee_Orders
{
    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var total = 0M;

            for (int i = 0; i < count; i++)
            {
                var capsulePrice = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var currentPrice = (daysInMonth * capsulesCount) * capsulePrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
                total += currentPrice;
            }

            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
