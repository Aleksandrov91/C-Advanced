using System;

namespace Charity_Marathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            int marathonLenght = int.Parse(Console.ReadLine());
            int totalRunners = int.Parse(Console.ReadLine());
            int averageLapsByRunner = int.Parse(Console.ReadLine());
            int trackLenght = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());
            if (totalRunners > (trackCapacity * marathonLenght))
            {
                totalRunners = trackCapacity;
            }

            double totalKilometers = (totalRunners * averageLapsByRunner * trackLenght) / 1000.0;
            double totalMoney = moneyPerKilometer * totalKilometers;
            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}