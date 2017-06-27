using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var pattern = @"\w+(|[\.\-])\w+@\w+(|[\.\-])\w+\.\w+(|\.)\w+";
            var regex = new Regex(pattern);
            var result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentString = input[i];
                var firstSybmol = currentString.ToCharArray();
                if (char.IsLetter(firstSybmol[0]))
                {
                    var match = regex.Match(currentString).ToString();
                    if (match != string.Empty)
                    {
                        result.Add(match);
                    }
                }
            }

            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}
