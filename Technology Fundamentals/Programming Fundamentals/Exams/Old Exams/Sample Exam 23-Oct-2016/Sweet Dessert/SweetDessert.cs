using System;

namespace Sweet_Dessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            var amountCash = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var berriesPrice = double.Parse(Console.ReadLine());

            var portionPrice = (2 * bananaPrice) + (4 * eggPrice) + (0.2 * berriesPrice);
            var totalPortions = Math.Ceiling(guests / 6.0);
            var totalMoney = (decimal)totalPortions * (decimal)portionPrice;

            if (totalMoney <= amountCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalMoney:F2}lv.");
            }
            else
            {
                var neededMoney = totalMoney - amountCash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
