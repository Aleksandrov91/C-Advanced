using System;
using System.Globalization;

namespace Day_of_Week
{
    public class DayOfWeek
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            var result = date.DayOfWeek;
            Console.WriteLine(result);
        }
    }
}
