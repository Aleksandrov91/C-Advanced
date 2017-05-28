using System;

namespace Charity_Marathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            var lengthOfMarathon = int.Parse(Console.ReadLine());
            var numOfRunners = int.Parse(Console.ReadLine());
            var averageLap = int.Parse(Console.ReadLine());
            var lengthOfTrack = decimal.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            var donatedMoney = decimal.Parse(Console.ReadLine());

            var maxRunners = lengthOfMarathon * capacityOfTrack;
            if (numOfRunners > maxRunners)
            {
                numOfRunners = maxRunners;
            }

            var totalKilometers = ((numOfRunners * averageLap) * lengthOfTrack) / 1000;
            var money = totalKilometers * donatedMoney;

            Console.WriteLine($"Money raised: {money:F2}");
        }
    }
}
