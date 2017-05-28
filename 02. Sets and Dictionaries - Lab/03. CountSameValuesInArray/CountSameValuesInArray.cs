using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03.CountSameValuesInArray
{
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x, NumberStyles.Any, CultureInfo.CurrentCulture))
                .ToArray();

            var numbers = new SortedDictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!numbers.ContainsKey(input[i]))
                {
                    numbers[input[i]] = 1;
                }
                else
                {
                    numbers[input[i]]++;
                }
            }

            foreach (var kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
