using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Jedi_Code_X
{
    public class JediCodeX
    {
        public static void Main()
        {
            var input = new StringBuilder();
            var linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                input.AppendLine(Console.ReadLine());
            }

            var firstLine = Console.ReadLine();
            var secondLine = Console.ReadLine();
            var firstPattern = $@"{firstLine}([a-zA-Z]+)";
            var secondPattern = $@"{secondLine}([a-zA-Z0-9]+)(?:(?=\W))";

            //string firstPattern = firstLine + @"([A-Za-z]{" + firstLine.Length + @"})";
            //string secondPattern = secondLine + @"([A-Za-z0-9]{" + secondLine.Length + @"})";

            var firstMatches = Regex.Matches(input.ToString(), firstPattern);
            var secondMatches = Regex.Matches(input.ToString(), secondPattern);
            var jediName = new string[firstMatches.Count];
            var jediMessage = new List<string>();

            var index = 0;
            foreach (Match match in firstMatches)
            {
                var currentMatch = match.Groups[1].Value;
                if (currentMatch.Length == firstLine.Length)
                {
                    jediName[index] = currentMatch;
                    index++;
                }
            }

            foreach (Match secondMatch in secondMatches)
            {
                var currentMatch = secondMatch.Groups[1].Value;
                if (currentMatch.Length == secondLine.Length)
                {
                    jediMessage.Add(currentMatch);
                }
            }

            var inexes = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < jediName.Length; i++)
            {
                for (int j = i; j < inexes.Length; j++)
                {
                    if (jediMessage.Count >= inexes[j])
                    {
                        Console.WriteLine($"{jediName[i]} - {jediMessage[inexes[j] - 1]}");
                        break;
                    }
                }

            }
        }
    }
}
