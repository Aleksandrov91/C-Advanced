using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Use_Your_Chains_Buddy
{
    public class UseYourChains
    {
        public static void Main()
        {
            var text = Console.ReadLine();            
            var decrypted = GetDecryptedalphabetic();
            var split = new Regex(@"<p>(.*?)<\/p>");
            var replace = new Regex(@"[^a-z0-9]");
            var matches = split.Matches(text);
            var sb = new StringBuilder();

            foreach (Match item in matches)
            {
                sb.Append(item.Groups[1]);
            }

            var matchedText = sb.ToString();
            matchedText = replace.Replace(matchedText, " ");
            var replacedText = matchedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var decryptedText = new List<char>();

            for (int i = 0; i < replacedText.Length; i++)
            {
                var currentWord = replacedText[i];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    var currentChar = currentWord[j];
                    if (decrypted.ContainsKey(currentChar))
                    {
                        decryptedText.Add(decrypted[currentChar]);
                    }
                    else
                    {
                        decryptedText.Add(currentChar);
                    }
                }

                decryptedText.Add(' ');
            }

            Console.WriteLine(string.Join(string.Empty, decryptedText));
        }

        public static Dictionary<char, char> GetDecryptedalphabetic()
        {
            var decryptedAlphabetic = new Dictionary<char, char>();
            var key = 13;

            for (char i = 'a'; i <= 'm'; i++)
            {
                decryptedAlphabetic[i] = (char)('a' + key);
                key++;
            }

            key--;

            for (char j = 'n'; j <= 'z'; j++)
            {
                decryptedAlphabetic[j] = (char)('z' - key);
                key--;
            }

            return decryptedAlphabetic;
        }
    }
}
