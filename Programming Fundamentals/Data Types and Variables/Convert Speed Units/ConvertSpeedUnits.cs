using System;

namespace Convert_Speed_Units
{
    public class ConvertSpeedUnits
    {
        public static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            sbyte hours = sbyte.Parse(Console.ReadLine());
            sbyte minutes = sbyte.Parse(Console.ReadLine());
            sbyte seconds = sbyte.Parse(Console.ReadLine());
            int totalSeconds = seconds + (minutes * 60) + (hours * 3600);
            float metersPerSecond = (float)meters / (float)totalSeconds;
            float kilometersPerHour = (meters / 1000F) / (totalSeconds / 3600F);
            float milesPerHour = kilometersPerHour / 1.609f;
            Console.WriteLine($"{metersPerSecond}\r\n{kilometersPerHour}\r\n{milesPerHour}");
        }
    }
}
