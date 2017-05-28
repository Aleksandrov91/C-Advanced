using System;
using System.Collections.Generic;
using System.Linq;

namespace Square_Numbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareNums = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                int currentNum = nums[i];
                if (Math.Sqrt(currentNum) == (int)Math.Sqrt(currentNum))
                {
                    squareNums.Add(currentNum);
                }
            }

            squareNums.Sort();
            squareNums.Reverse();
            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
