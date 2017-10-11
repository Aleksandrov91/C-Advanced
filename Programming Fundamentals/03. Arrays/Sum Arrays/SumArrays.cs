using System;
using System.Linq;

namespace Sum_Arrays
{
    public class SumArrays
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');
            int[] firstParsed = new int[firstArr.Length];
            int[] secondParsed = new int[secondArr.Length];
            GetParsedArr(firstArr, firstParsed);
            GetParsedArr(secondArr, secondParsed);
            int longestArr = Math.Max(firstParsed.Length, secondParsed.Length);
            int[] sumArr = new int[longestArr];
            for (int i = 0; i < longestArr; i++)
            {
                int lenght1 = i % firstParsed.Length;
                int lenght2 = i % secondParsed.Length;
                sumArr[i] = firstParsed[lenght1] + secondParsed[lenght2];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }

        public static void GetParsedArr(string[] arr, int[] parsedArr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                parsedArr[i] = int.Parse(arr[i]);
            }
        }
    }
}
