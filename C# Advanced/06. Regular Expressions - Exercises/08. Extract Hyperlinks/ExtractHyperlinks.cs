namespace _08.Extract_Hyperlinks
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ExtractHyperlinks
    {
        public static void Main()
        {
            //var pattern = @"<a.*?[^>]+href\s*=\s*(?:(['""""])(.*?)\1|(.*?)[ >])";
            var pattern = @"<a.*?[^>]+href\s*=\s*(?:(['""""])(?'text'.*?)\1|(?'text'.*?)[ >])";
            var inputLine = Console.ReadLine();
            var html = new StringBuilder();
            var validHrefs = new StringBuilder();

            while (inputLine != "END")
            {
                html.Append(inputLine);
                inputLine = Console.ReadLine();
            }

            var matches = Regex.Matches(html.ToString(), pattern);

            foreach (Match match in matches)
            {
                //if (match.Groups[3].Value != string.Empty)
                //{
                //    validateTags.AppendLine(match.Groups[3].Value);
                //}
                //else
                //{
                //    validateTags.AppendLine(match.Groups[2].Value);
                //}

                validHrefs.AppendLine(match.Groups["text"].Value);
            }

            Console.WriteLine(validHrefs.ToString());
        }
    }
}
