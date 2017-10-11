using System;

namespace Condense_Arrays
{
    public class CondenseArray
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numsArr = new int[input.Length];
            for (int i = 0; i < numsArr.Length; i++)
            {
                numsArr[i] = int.Parse(input[i]);
            }

            for (int k = numsArr.Length; k > 1; k--)
            {
                int[] condensed = new int[numsArr.Length - 1];
                for (int j = 0; j < numsArr.Length - 1; j++)
                {
                    condensed[j] = numsArr[j] + numsArr[j + 1];
                }

                numsArr = condensed;
            }

            Console.WriteLine(numsArr[0]);
        }
    }
}
