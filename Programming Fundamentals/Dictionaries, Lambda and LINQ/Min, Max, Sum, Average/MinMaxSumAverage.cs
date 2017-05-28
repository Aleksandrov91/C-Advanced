using System;
using System.Collections.Generic;
using System.Linq;

namespace Min__Max__Sum__Average
{
    public class MinMaxSumAverage
    {
        public static void Main()
        {
            var numCount = int.Parse(Console.ReadLine());
            var temp = new List<string>();
            for (int i = 0; i < numCount; i++)
            {
                temp.Add(Console.ReadLine());
            }

            var result = temp.Select(int.Parse).ToList();
            int sum = result.Sum();
            int min = result.Min();
            int max = result.Max();
            double average = result.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
