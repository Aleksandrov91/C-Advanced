using System;

namespace _03.Parse_Tags
{
    public class ParseTags
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            var index = text.IndexOf(openTag);

            while (index != -1)
            {
                if (text.IndexOf(closeTag) == -1)
                {
                    break;
                }
                var startIndex = text.IndexOf("<upcase>");
                var endIndex = text.IndexOf("</upcase>");

                var textToChange = text.Substring(startIndex, endIndex + closeTag.Length - startIndex);
                var replaced = textToChange.Replace(openTag, string.Empty)
                    .Replace(closeTag, string.Empty)
                    .ToUpper();

                text = text.Replace(textToChange, replaced);

                index = text.IndexOf(openTag);
            }

            Console.WriteLine(text);
        }
    }
}
