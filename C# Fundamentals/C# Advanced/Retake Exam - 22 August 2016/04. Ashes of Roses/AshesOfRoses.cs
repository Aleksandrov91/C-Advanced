using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Ashes_of_Roses
{
    public class AshesOfRoses
    {
        public static void Main()
        {
            var pattern = @"^Grow\s*<([A-Z][a-z]+)>\s*<([A-Za-z0-9]+)>\s*(\d+)$";
            var inputLine = Console.ReadLine();
            var roses = new Dictionary<string, Dictionary<string, long>>();

            while (inputLine != "Icarus, Ignite!")
            {
                var match = Regex.Match(inputLine, pattern);

                if (match.Success)
                {
                    if (!roses.ContainsKey(match.Groups[1].Value))
                    {
                        roses[match.Groups[1].Value] = new Dictionary<string, long>();
                    }

                    if (!roses[match.Groups[1].Value].ContainsKey(match.Groups[2].Value))
                    {
                        roses[match.Groups[1].Value][match.Groups[2].Value] = 0;
                    }

                    roses[match.Groups[1].Value][match.Groups[2].Value] += long.Parse(match.Groups[3].Value);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var region in roses.OrderByDescending(x => x.Value.Sum(s => s.Value)).ThenBy(x => x.Key)) /*.OrderByDescending(v => v.Value)*/
            {
                Console.WriteLine(region.Key);

                foreach (var roseType in region.Value.OrderBy(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"*--{roseType.Key} | {roseType.Value}");
                }
            }
        }
    }
}
