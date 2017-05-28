using System;
using System.Linq;

namespace Most_Frequent_Number
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int count = 1;
            int maxCount = 0;
            int value = 0;
            for (int index = 0; index < nums.Length; index++)
            {
                int currentNum = nums[index];
                for (int check = index + 1; check < nums.Length; check++)
                {
                    int nextNum = nums[check];
                    if (currentNum == nextNum)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    count = 1;
                    value = currentNum;
                }

                count = 1;
            }

            Console.WriteLine(value);
        }
    }
}
