namespace _05.Extract_Email
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmail
    {
        public static void Main()
        {
            var pattern = @"(?<=(\s))[a-zA-Z0-9][\w-.]*[a-zA-Z0-9]@[a-zA-Z][a-zA-Z-]*[a-zA-Z](\.[a-zA-Z][a-zA-Z-]*[a-zA-Z])+(?=\b)";
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
