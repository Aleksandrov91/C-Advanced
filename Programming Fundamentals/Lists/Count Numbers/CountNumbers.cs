using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Numbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            nums.Sort();
            int count = 1;
            nums.Add(int.MaxValue);
            for (int i = 1; i < nums.Count; i++)
            {
                int currentNum = nums[i];
                int previousNum = nums[i - 1];
                if (currentNum == previousNum)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{previousNum} -> {count}");
                    count = 1;
                }
            }
        }
    }
}
