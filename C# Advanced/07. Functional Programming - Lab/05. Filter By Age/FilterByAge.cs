using System;
using System.Collections.Generic;

namespace _05.Filter_By_Age
{
    public class FilterByAge
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var statistic = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine().Split(' ');
                statistic.Add(row[0], int.Parse(row[1]));
            }

        }
    }
}
