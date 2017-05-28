using System;
using System.Collections.Generic;
using System.Linq;

namespace Increasing_Sequence
{
    public class IncreasingSequence
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var len = new int[sequence.Length];
            int maxLenght = 0;
            int lastIndex = -1;
            var prev = new int[sequence.Length];
            for (int i = 0; i < sequence.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && len[j] + 1 > len[i])
                    {
                        len[i] = 1 + len[i];
                        prev[i] = j;
                    }

                    if (len[i] > maxLenght)
                    {
                        maxLenght = len[i];
                        lastIndex = i;
                    }
                }
            }

            if (sequence.Length == 1)
            {
                Console.WriteLine(1);
            }

            var longestSequence = new List<int>();
            while (lastIndex != -1)
            {
                longestSequence.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSequence.Reverse();
            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}
