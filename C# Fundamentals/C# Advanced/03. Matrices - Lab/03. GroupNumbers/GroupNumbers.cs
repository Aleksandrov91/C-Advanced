using System;
using System.Linq;

namespace _03.GroupNumbers
{
    public class GroupNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var size = new int[3];

            for (int i = 0; i < input.Length; i++)
            {
                var reminder = Math.Abs(input[i] % 3);
                size[reminder]++;
            }

            int[][] matrix =
            {
                new int[size[0]],
                new int[size[1]],
                new int[size[2]]
            };

            var offset = new int[3];

            for (int i = 0; i < input.Length; i++)
            {
                var reminder = Math.Abs(input[i] % 3);
                var index = offset[reminder];
                matrix[reminder][index] = input[i];
                offset[reminder]++;
            }

            foreach (var element in matrix)
            {
                Console.WriteLine(string.Join(" ", element));
            }
        }
    }
}
