using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    public class LargestNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderByDescending(n => n)
                .Take(3).ToList();
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
