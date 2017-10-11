using System;
using System.Collections.Generic;
using System.Linq;

namespace Negatives_Reverse
{
    public class NegativesReverse
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            numbers.Reverse();
            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
