using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"\b[A-Za-z]\w{2,24}\b";
            var regex = new Regex(pattern);
            var result = new List<string>();
            var matches = regex.Matches(input);
            var count = 0;
            var maxcount = 0;
            for (int i = 0; i < matches.Count - 1; i++)
            {
                var firstWord = matches[i];
                var secondWord = matches[i + 1];
                count = firstWord.Length + secondWord.Length;

                if (count > maxcount)
                {
                    result.Clear();
                    result.Add(firstWord.ToString());
                    result.Add(secondWord.ToString());
                    maxcount = count;
                }
            }

            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}
