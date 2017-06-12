namespace _09.Query_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            var pattern = @"(?'key'.+)=(?'value'.+)";
            var line = Console.ReadLine();
            while (line != "END")
            {
                var keys = new Dictionary<string, HashSet<string>>();
                line = Regex.Replace(line, @"(%20|\+)+", @" ");
                var lineArgs = line.Split(new[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var data in lineArgs)
                {
                    var match = Regex.Match(data, pattern);
                    if (match.Success)
                    {
                        var key = match.Groups["key"].Value.Trim();
                        var value = match.Groups["value"].Value.Trim();

                        if (!keys.ContainsKey(key))
                        {
                            keys[key] = new HashSet<string>() { value };
                        }
                        else
                        {
                            keys[key].Add(value);
                        }
                    }
                }

                foreach (var kvp in keys)
                {
                    Console.Write($"{kvp.Key}=");
                    Console.Write($"[{string.Join(", ", kvp.Value.Select(s => $"{s}"))}]");
                }

                Console.WriteLine();

                line = Console.ReadLine();
            }
        }
    }
}
