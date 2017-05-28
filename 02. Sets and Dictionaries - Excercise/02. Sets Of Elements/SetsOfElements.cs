using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sets_Of_Elements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var repeatingElements = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                var num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }

            for (int i = 0; i < input[1]; i++)
            {
                var num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    repeatingElements.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", repeatingElements));
        }
    }
}
