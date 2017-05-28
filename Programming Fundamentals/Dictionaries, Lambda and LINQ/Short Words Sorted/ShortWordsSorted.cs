using System;
using System.Collections.Generic;
using System.Linq;

namespace Short_Words_Sorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?' },StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .OrderBy(n => n)
                .Where(n => n.Length < 5)
                .ToList();
            Console.WriteLine(string.Join(", ", text));
        }
    }
}
