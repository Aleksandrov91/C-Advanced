namespace _03.Series_Of_Letters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            var pattern = @"([a-z])\1+";
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                input = input.Replace(match.Value.ToString(), match.Groups[1].ToString());
            }

            //var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            //input = regex.Replace(input, "$1");

            Console.WriteLine(input);
        }
    }
}
