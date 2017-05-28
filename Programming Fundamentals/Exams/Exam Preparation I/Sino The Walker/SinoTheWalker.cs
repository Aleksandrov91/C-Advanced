using System;

namespace Sino_The_Walker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            var timeLeave = DateTime.Parse(Console.ReadLine());
            var steps = int.Parse(Console.ReadLine()) % 86400;
            var eachStep = int.Parse(Console.ReadLine()) % 86400;

            var walkingTime = steps * eachStep;

            TimeSpan convertedTime = TimeSpan.FromSeconds(walkingTime);

            var result = timeLeave + convertedTime;

            Console.WriteLine($"Time Arrival: {result:HH:mm:ss}");
        }
    }
}
