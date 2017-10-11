using System;
using System.Collections.Generic;

namespace _04.Count_Symbols
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var letterCount = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!letterCount.ContainsKey(input[i]))
                {
                    letterCount[input[i]] = 1;
                }
                else
                {
                    letterCount[input[i]]++;
                }
            }

            foreach (var kvp in letterCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
