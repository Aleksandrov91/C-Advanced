using System;

namespace Day_of_Week
{
     public class DayOfWeek
    {
        public static void Main()
        {
            int dayNumber = int.Parse(Console.ReadLine());
            var daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (dayNumber <= 0 || dayNumber > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[dayNumber - 1]);
            }
        }
    }
}
