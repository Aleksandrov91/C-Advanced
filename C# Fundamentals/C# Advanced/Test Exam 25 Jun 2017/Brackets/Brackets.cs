using System;
using System.Text.RegularExpressions;

namespace Brackets
{
    public class Brackets
    {
        public static void Main()
        {
            //var regex = new Regex(@"([[({])(.*?)(?:[)\]}])");
            var regex = new Regex(@"([[({])(.*?)\1");
            var input = Console.ReadLine();
            input = Regex.Replace(input, @"\]", "[");
            input = Regex.Replace(input, @"\)", "(");
            input = Regex.Replace(input, @"\}", "{");
            var matches = regex.Matches(input);
            var result = 0;

            foreach (Match match in matches)
            {
                if (match.Groups[2].Value.Contains("(")||
                match.Groups[2].Value.Contains("[")||
                match.Groups[2].Value.Contains("{"))
                {

                }
                var multiplier = 0;
                var commas = 0;
                var otherSymbols = 0;
                var temp = 0;

                if (match.Groups[1].Value == "(")
                {
                    multiplier = 2;
                }
                else if (match.Groups[1].Value == "[")
                {
                    multiplier = 3;
                }
                else
                {
                    multiplier = 5;
                }
                var text = match.Groups[2].Value;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ',')
                    {
                        commas++;
                    }
                    else
                    {
                        otherSymbols++;
                    }
                }

                temp = commas * otherSymbols * multiplier;
                result += temp;
            }

            Console.WriteLine(result);
        }
    }
}
