using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var bombNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int bombNumber = bombNums[0];
            int range = bombNums[1];

            for (int i = 0; i < nums.Count; i++)
            {
                int currentNum = nums[i];
                if (currentNum == bombNumber)
                {
                    for (int j = i; j < i + range; j++)
                    {
                        int nextNum = i + 1;
                        if (j == nums.Count)
                        {
                            nums.RemoveAt(j - 1);
                            break;
                        }
                        nums.RemoveAt(nextNum);
                    }
                    for (int k = i - 1; k >= i - range; k--)
                    {
                        if (k < 0)
                        {
                            //nums.RemoveAt(k);
                            break;
                        }
                        nums.RemoveAt(k);
                    }
                    nums.Remove(bombNumber);
                    i = 0;
                }
            }
            int sum = nums.Sum();
            Console.WriteLine(sum);
            //Console.WriteLine(string.Join(" ", nums));
        }
    }
}
