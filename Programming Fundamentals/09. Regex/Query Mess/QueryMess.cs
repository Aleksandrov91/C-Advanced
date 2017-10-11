using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Query_Mess
{
    public class QueryMess
    {
        public static void Main()
        {
            var separated = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();
            var pattern = @"(\+|%20)+";
            var regex = new Regex(pattern);
            while (input != "END")
            {
                var line = input.Split(new[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < line.Length; i++)
                {
                    if (!line[i].Contains("="))
                    {
                        continue;
                    }

                    line[i] = regex.Replace(line[i], " ");
                    var kvp = line[i].Split('=');
                    var key = kvp[0].Trim();
                    var value = kvp[1].Trim();
                    if (!separated.ContainsKey(key))
                    {
                        separated[key] = new List<string>();
                    }

                    separated[key].Add(value);
                }

                foreach (var item in separated)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }

                separated.Clear();
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
