using System;
using System.Text.RegularExpressions;

namespace Extract_sentences_by_keyword
{
    public class ExtractSentences
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();
            var text = Console.ReadLine().Split(new[] { '.', '!', '?' },StringSplitOptions.RemoveEmptyEntries);
            var pattern = "\\b" + keyWord + "\\b";
            var regex = new Regex(pattern);

            foreach (var sentence in text)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.ToString());
                }
            }
        }
    }
}
