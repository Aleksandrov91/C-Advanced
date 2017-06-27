using System;

namespace Rounding_Numbers
{
    public class RoundingNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] arr = new double[input.Length];
            int[] roundedNumbers = new int[arr.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = double.Parse(input[i]);
                roundedNumbers[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < roundedNumbers.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => {roundedNumbers[i]}");
            }
        }
    }
}
