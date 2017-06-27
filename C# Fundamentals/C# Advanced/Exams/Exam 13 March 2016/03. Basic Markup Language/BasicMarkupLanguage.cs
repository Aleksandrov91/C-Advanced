namespace _03.Basic_Markup_Language
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class BasicMarkupLanguage
    {
        private static StringBuilder result = new StringBuilder();

        public static void Main()
        {
            string pattern = @"\s*<\s*([a-z]+)\s+(?:value\s*=\s*""\s*(\d+)\s*""\s+)?[a-z]+\s*=\s*""([^""]*)""\s*\/>\s*";
            var inputLine = Console.ReadLine();
            var lineCount = 1;
            while (inputLine != "<stop/>")
            {
                var match = Regex.Match(inputLine, pattern);
                var operation = match.Groups[1].Value;
                var content = string.Empty;
                var value = 0;
                switch (operation)
                {
                    case "inverse":
                        content = match.Groups[3].Value;
                        if (content == string.Empty)
                        {
                            inputLine = Console.ReadLine();
                            continue;
                        }

                        InverseChars(content, lineCount);
                        lineCount++;
                        break;
                    case "reverse":
                        content = match.Groups[3].Value;
                        if (content == string.Empty)
                        {
                            inputLine = Console.ReadLine();
                            continue;
                        }

                        var reversed = content.ToCharArray();
                        Array.Reverse(reversed);
                        result.AppendLine($"{lineCount}. {new string(reversed)}");
                        lineCount++;

                        break;
                    case "repeat":
                        value = int.Parse(match.Groups[2].Value);
                        content = match.Groups[3].Value;
                        if (content == string.Empty)
                        {
                            inputLine = Console.ReadLine();
                            continue;
                        }

                        for (int i = 0; i < value; i++)
                        {
                            result.AppendLine($"{lineCount}. {content}");
                            lineCount++;
                        }

                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(result);
        }

        private static void InverseChars(string content, int lineCount)
        {
            var temp = new StringBuilder();
            for (int i = 0; i < content.Length; i++)
            {
                if (char.IsUpper(content[i]))
                {
                    temp.Append(char.ToLower(content[i]));
                }
                else
                {
                    temp.Append(char.ToUpper(content[i]));
                }
            }

            if (temp.Length > 0)
            {
                result.AppendLine($"{lineCount}. {temp}");
            }
        }
    }
}
