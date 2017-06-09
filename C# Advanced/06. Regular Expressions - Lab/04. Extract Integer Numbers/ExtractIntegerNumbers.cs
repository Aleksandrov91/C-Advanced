using System;
using System.Text.RegularExpressions;

namespace _04.Extract_Integer_Numbers
{
    public class ExtractIntegerNumbers
    {
        public static void Main()
        {
            var patter = @"\d+";
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, patter);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
