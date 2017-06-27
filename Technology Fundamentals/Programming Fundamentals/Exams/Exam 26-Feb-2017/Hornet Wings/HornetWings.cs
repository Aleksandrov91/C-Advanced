using System;

namespace Hornet_Wings
{
    public class HornetWings
    {
        public static void Main()
        {
            var flaps = long.Parse(Console.ReadLine());
            var distance = decimal.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var meters = flaps / 1000 * distance;
            var seconds = flaps / 100M;
            var pause = flaps / endurance * 5;
            seconds += pause;

            Console.WriteLine($"{meters:F2} m.");
            Console.WriteLine($"{seconds} s.");
        }
    }
}
