namespace _06.Sentence_Extractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();
            var pattern = $"[\\w\\s]+?\\b{keyWord}\\b.*?(!|\\?|\\.)";
            var text = Console.ReadLine();
            var matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
