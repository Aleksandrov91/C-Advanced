using System;
using System.Text.RegularExpressions;

namespace _08.Extract_Quotations
{
    public class ExtractQuotations
    {
        public static void Main()
        {
            var pattern = @"(""|')(.+?)\1";
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
