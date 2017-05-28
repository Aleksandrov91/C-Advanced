using System;
using System.Collections.Generic;
using System.Linq;

namespace Increasing_Elements
{
    public class IncreasingElements
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = new List<int>();
            int count = 1;
            int maxCount = 1;
            int firstElement = 0;
            int previousNum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                if (currentNum > previousNum)
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        firstElement = i;
                    }
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        firstElement = i;
                    }

                    count = 1;
                }

                previousNum = currentNum;
            }

            for (int j = maxCount - 1; j >= 0; j--)
            {
                result.Add(nums[firstElement - j]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
