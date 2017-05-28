using System;
using System.Linq;

namespace Equal_Sums
{
    public class EqualSums
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            if (nums.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
            else
            {
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    int middleNum = nums.Length - i - 1;

                    for (int left = 0; left < middleNum; left++)
                    {
                        leftSum += nums[left];
                    }

                    for (int right = nums.Length - 1; right > middleNum; right--)
                    {
                        rightSum += nums[right];
                    }

                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(middleNum);
                        return;
                    }

                    leftSum = 0;
                    rightSum = 0;
                }
            }

            Console.WriteLine("no");
        }
    }
}
