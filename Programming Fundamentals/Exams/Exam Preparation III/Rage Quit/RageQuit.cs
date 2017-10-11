using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Rage_Quit
{
    public class RageQuit
    {
        public static void Main()
        {
            string pattern = @"([a-zA-z\W]+)(\d+)";
            var regex = new Regex(pattern);
            var input = Console.ReadLine();
            var matches = regex.Matches(input);
            var sb = new StringBuilder();
            foreach (Match match in matches)
            {
                var repeater = int.Parse(match.Groups[2].ToString());
                var text = match.Groups[1].ToString();
                for (int i = 0; i < repeater; i++)
                {
                    sb.Append(text.ToUpper());
                }
            }

            var inqueSymbols = sb.ToString().Distinct().ToArray();
            Console.WriteLine($"Unique symbols used: {inqueSymbols.Length}");
            Console.WriteLine(string.Join(string.Empty, sb)); 
        }
    }
}
