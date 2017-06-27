using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Sino_The_Walker_2
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            var dateFormat = "HH:mm:ss";
            var timeLeave = DateTime.ParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine());
            var secondsOfStep = int.Parse(Console.ReadLine());

            ulong walkingTime = (ulong)steps * (ulong)secondsOfStep;
            ulong totalseconds = (ulong)timeLeave.Second + walkingTime;
            ulong totalMinutes = (ulong)timeLeave.Minute / 60;
            ulong totalHours = (ulong)timeLeave.Hour / 60 * 60;

            ulong hours = (totalseconds / 60 * 60) % 24;
            ulong minutes = (totalseconds / 60) % 60;
            ulong seconds = totalseconds % 60;

            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}
