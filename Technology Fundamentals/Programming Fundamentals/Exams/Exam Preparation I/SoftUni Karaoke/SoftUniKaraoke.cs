using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Karaoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participants = GetSplitted(Console.ReadLine());
            var songs = GetSplitted(Console.ReadLine());
            var line = Console.ReadLine();
            var result = new Dictionary<string, List<string>>();

            while (line != "dawn")
            {
                var data = GetSplitted(line).ToArray();
                var participant = data.First();
                var song = data[1];
                var award = data.Last();

                if (participants.Contains(participant)
                    && songs.Contains(song))
                {
                    if (!result.ContainsKey(participant))
                    {
                        result[participant] = new List<string>();
                    }

                    if (!result[participant].Contains(award))
                    {
                        result[participant].Add(award);
                    }
                }

                line = Console.ReadLine();
            }

            if (result.Values.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var kvp in result
                                .OrderByDescending(kvp => kvp.Value.Count)
                                .ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");

                foreach (var award in kvp.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }

        public static IEnumerable<string> GetSplitted(string input)
        {
            var splitted = input
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim());
            return splitted;
        }
    }
}
