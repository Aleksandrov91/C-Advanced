using System;

namespace Largest_Common_End
{
    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');
            int lowerstArr = Math.Min(firstArr.Length, secondArr.Length);
            int longestArr = Math.Max(firstArr.Length, secondArr.Length);
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < lowerstArr; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    leftSum++;
                }
            }
            int difference = longestArr - lowerstArr;
            for (int j = lowerstArr - 1; j >= 0; j--)
            {
                if (firstArr.Length > secondArr.Length && firstArr[j + difference] == secondArr[j])
                {
                    rightSum++;
                }
                else if (firstArr.Length < secondArr.Length && firstArr[j] == secondArr[j + difference])
                {
                    rightSum++;
                }
            }
            Console.WriteLine(Math.Max(leftSum, rightSum));
        }
    }
}
