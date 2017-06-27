using System;
using System.Collections.Generic;
using System.Linq;

namespace Fold_and_Sum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int k = input.Count / 4;
            var leftRow = input
                .Take(k)
                .Reverse()
                .ToList();
            var rightRow = input.Skip(3 * k)
                .Reverse()
                .ToList();
            var firstRow = leftRow.Concat(rightRow).ToList();
            var secondRow = input.Skip(k)
                .Take(2 * k)
                .ToList();
            var result = firstRow.Select((x, index) => x + secondRow[index])
                .ToList();
            Console.WriteLine(string.Join(" ", result));




        }
    }
}
