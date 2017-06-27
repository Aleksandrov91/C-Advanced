using System;
using System.Linq;

namespace Fold_and_Sum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] foldA = new int[nums.Length / 4];
            int[] foldB = new int[nums.Length / 4];
            int[] sumArr = new int[nums.Length / 2];
            for (int i = 0; i < nums.Length / 4; i++)
            {
                foldA[i] = nums[(nums.Length / 4) - i - 1];
                foldB[i] = nums[nums.Length - i - 1];
            }
            for (int i = 0; i < nums.Length / 4; i++)
            {
                sumArr[i] = foldA[i] + nums[nums.Length / 4 + i];
                sumArr[nums.Length / 4 + i] = foldB[i] + nums[nums.Length / 2 + i];
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
