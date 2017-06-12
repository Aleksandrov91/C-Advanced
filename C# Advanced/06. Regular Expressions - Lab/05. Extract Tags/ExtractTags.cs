namespace _05.Extract_Tags
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractTags
    {
        public static void Main()
        {
            var pattern = @"<.*?>";
            var input = Console.ReadLine();

            while (input != "END")
            {
                var matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
