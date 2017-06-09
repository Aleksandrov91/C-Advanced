using System;
using System.Text.RegularExpressions;

namespace _01.Match_Count
{
    public class MatchCount
    {
        public static void Main()
        {
            var pattern = Console.ReadLine();
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            Console.WriteLine(matches.Count);
        }
    }
}
