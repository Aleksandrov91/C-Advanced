using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Numbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();
            nums.Sort();
            //nums.Add(decimal.MaxValue);
            //for (int i = 0; i < nums.Count - 1; i++)
            //{
            //    decimal currentNum = nums[i];
            //    decimal nextNum = nums[i + 1];
            //    if (i == nums.Count - 2)
            //    {
            //        Console.Write($"{currentNum} <= {nextNum}");
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.Write($"{currentNum} <= {nextNum} <=");
            //        i++;
            //    }
            //}
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
