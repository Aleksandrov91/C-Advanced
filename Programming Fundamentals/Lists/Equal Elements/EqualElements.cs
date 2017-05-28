using System;
using System.Collections.Generic;
using System.Linq;

namespace Equal_Elements
{
    public class EqualElements
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var result = new List<int>();
            int count = 1;
            int maxCount = 0;
            int value = 0;
            int previousNum = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                int currentNum = nums[i];
                if (previousNum == currentNum)
                {
                    count++;
                    if (count > maxCount)
                    {
                        value = previousNum;
                        maxCount = count;
                    }
                }
                else
                {
                    if (count > maxCount)
                    {
                        value = previousNum;
                        maxCount = count;
                    }
                    count = 1;
                }

                previousNum = currentNum;
            }

            for (int i = 0; i < maxCount; i++)
            {
                if (i == maxCount - 1)
                {
                    Console.Write(value);
                }
                else
                {
                    Console.Write(value + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
