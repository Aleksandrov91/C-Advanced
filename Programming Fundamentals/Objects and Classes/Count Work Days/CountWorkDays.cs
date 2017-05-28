using System;
using System.Globalization;
using System.Linq;

namespace Count_Work_Days
{
    public class CountWorkDays
    {
        public static void Main()
        {
            var startDate = Console.ReadLine();
            var endDate = Console.ReadLine();
            var firstDate = DateTime.ParseExact(startDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(endDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            var holidays = new DateTime[]
            {
                new DateTime(2016, 01, 01),
                new DateTime(2016, 03, 03),
                new DateTime(2016, 05, 01),
                new DateTime(2016, 05, 06),
                new DateTime(2016, 05, 24),
                new DateTime(2016, 09, 06),
                new DateTime(2016, 09, 22),
                new DateTime(2016, 11, 01),
                new DateTime(2016, 12, 24),
                new DateTime(2016, 12, 25),
                new DateTime(2016, 12, 26)
            };

            int workingDays = 0;
            for (DateTime currentDate = firstDate; currentDate <= secondDate; currentDate = currentDate.AddDays(1))
            {
                var temp = new DateTime(2016, currentDate.Month, currentDate.Day);
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(temp))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
