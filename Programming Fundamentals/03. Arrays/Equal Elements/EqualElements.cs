using System;
using System.Linq;

namespace Equal_Elements
{
    public class EqualElements
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int value = 0;
            int count = 1;
            int maxCount = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[j - 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        value = nums[j - 1];
                        maxCount = count;
                    }
                }
                else if (count > maxCount)
                {
                    maxCount = count;
                    count = 1;
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
