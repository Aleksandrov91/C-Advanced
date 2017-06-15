using System;
using System.Linq;

namespace _08.Custom_Comparator
{
    public class CustomComparator
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderBy(x => x)
                .OrderBy(x => x % 2 != 0)
                .ThenBy(x => x % 2 == 0)
                .ToArray()));
        }
    }
}
