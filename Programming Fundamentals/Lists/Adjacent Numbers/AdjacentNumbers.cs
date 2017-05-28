using System;
using System.Collections.Generic;
using System.Linq;

namespace Adjacent_Numbers
{
    public class AdjacentNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 1; i < input.Count; i++)
            {
                int currentNum = i;
                int previousNum = i - 1;
                if (input[currentNum] == input[previousNum])
                {
                    double sum = input[currentNum] + input[previousNum];
                    input[currentNum] = sum;
                    input.RemoveAt(previousNum);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
