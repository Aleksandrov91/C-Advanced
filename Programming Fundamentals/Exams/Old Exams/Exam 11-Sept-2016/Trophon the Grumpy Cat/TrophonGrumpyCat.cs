using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trophon_the_Grumpy_Cat
{
    public class TrophonGrumpyCat
    {
        public static void Main()
        {
            var ratings = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var entryPoint = int.Parse(Console.ReadLine());
            var typeOfItems = Console.ReadLine();
            var priceRating = Console.ReadLine();

            if (entryPoint < 1 && entryPoint > ratings.Length - 1)
            {
                return;
            }

            var left = ratings.Take(entryPoint).ToArray();
            var right = ratings.Skip(entryPoint + 1).ToArray();
            var factor = ratings[entryPoint];
            var leftSum = GetSum(left, typeOfItems, priceRating, entryPoint, factor);
            var rightSum = GetSum(right, typeOfItems, priceRating, entryPoint, factor);

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }

        public static long GetSum(int[] arr, string typeOfItems, string priceRating, int entryPoint, int factor)
        {
            long sum = 0;
            if (typeOfItems == "cheap")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (priceRating == "positive" && arr[i] > 0 && arr[i] < factor)
                    {
                        sum += arr[i];
                    }
                    else if (priceRating == "negative" && arr[i] < 0 && arr[i] < factor)
                    {
                        sum += arr[i];
                    }
                    else if (priceRating == "all" && arr[i] < factor)
                    {
                        sum += arr[i];
                    }
                }
            }
            else if (typeOfItems == "expensive")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (priceRating == "positive" && arr[i] > 0 && arr[i] >= factor)
                    {
                        sum += arr[i];
                    }
                    else if (priceRating == "negative" && arr[i] < 0 && arr[i] >= factor)
                    {
                        sum += arr[i];
                    }
                    else if (priceRating == "all" && arr[i] >= factor)
                    {
                        sum += arr[i];
                    }
                }
            }

            return sum;
        }
    }
}
