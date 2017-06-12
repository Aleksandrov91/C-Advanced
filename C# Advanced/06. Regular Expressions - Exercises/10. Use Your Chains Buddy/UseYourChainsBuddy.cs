namespace _10.Use_Your_Chains_Buddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            var pattern = @"<p>(.+?)<\/p>";
            var document = Console.ReadLine();
            var cryptedMessage = new StringBuilder();

            var matches = Regex.Matches(document, pattern);
            foreach (Match match in matches)
            {
                var reminder = match.Groups[1].ToString();
                reminder = Regex.Replace(reminder, @"[^a-z0-9]+", " ");
                cryptedMessage.Append(reminder);
            }

            var decryptedMessage = DecryptMessage(cryptedMessage.ToString());

            Console.WriteLine(decryptedMessage);
        }

        private static string DecryptMessage(string cryptedMessage)
        {
            cryptedMessage = Regex.Replace(cryptedMessage, @"\s+", " ");
            var decryptedMessage = new StringBuilder();
            for (int i = 0; i < cryptedMessage.Length; i++)
            {
                var currentChar = cryptedMessage[i];
                if (char.IsLetter(currentChar) && currentChar <= 'm')
                {
                    currentChar = (char)(currentChar + 13);
                }
                else if (char.IsLetter(currentChar) && currentChar > 'm')
                {
                    currentChar = (char)(currentChar - 13);
                }

                decryptedMessage.Append(currentChar);
            }

            return decryptedMessage.ToString();
        }
    }
}
