using System;
using System.Linq;

namespace Tripple_Sum
{
    public class TrippleSum
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool IsEqual = true;
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    int sum = arr[a] + arr[b];
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (sum == arr[c])
                        {
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {arr[c]}");
                            IsEqual = false;
                            break;
                        }
                    }
                }
            }
            if (IsEqual)
            {
                Console.WriteLine("No");
            }
        }
    }
}
