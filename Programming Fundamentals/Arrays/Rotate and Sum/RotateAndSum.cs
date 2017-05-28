using System;
using System.Linq;

namespace Rotate_and_Sum
{
    public class RotateAndSum
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[nums.Length];

            for (int i = 1; i <= n; i++)
            {
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;
                Console.WriteLine(string.Join(" ", nums));
            }

            //    for (int k = 0; k < nums.Length; k++)
            //    {
            //        sum[k] += nums[k];

            //    }
            //}
            //Console.WriteLine(string.Join(" ", sum));
        }
    }
}
