namespace _04.Replace_a_tag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            var pattern = @"(<a)\shref=(""|').+\2(>).+(<\/a>)";
            var input = Console.ReadLine();

            while (input != "end")
            {
                var matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    var reminder = match.ToString();
                    reminder = reminder.Replace(match.Groups[1].Value.ToString(), "[URL");
                    reminder = reminder.Replace(match.Groups[4].Value.ToString(), "[/URL]");
                    reminder = reminder.Replace(match.Groups[3].Value.ToString(), "]");
                    input = input.Replace(match.ToString(), reminder);
                }

                Console.WriteLine(input);

                input = Console.ReadLine();
            }
        }
    }
}
