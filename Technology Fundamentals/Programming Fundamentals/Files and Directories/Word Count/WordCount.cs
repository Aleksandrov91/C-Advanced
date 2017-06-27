using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    public class WordCount
    {
        public static void Main()
        {
            var text = File.ReadAllText("text.txt").ToLower().Split(new[] { ' ', '!', '?', ',', '-', '\r', '\n', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var words = File.ReadAllText("words.txt").ToLower().Split().ToArray();
            var result = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    int count = 0;
                    if (!result.ContainsKey(words[i]))
                    {
                        result[words[i]] = count;
                    }

                    if (words[i] == text[j])
                    {
                        result[words[i]]++;
                    }
                }
            }

            foreach (var item in result.OrderByDescending(kvp => kvp.Value))
            {
                File.AppendAllText("result.txt", $"{item.Key} - {item.Value}\r\n");
            }
        }
    }
}
