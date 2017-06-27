using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Serbian_Unleashed
{
    public class SerbianUnleashed
    {
        const string Pattern = @"([a-zA-Z]+\s){1,3}@([a-zA-Z0-9]+\s){1,3}[0-9]+\s[0-9]+";

        public static void Main()
        {
            string input = Console.ReadLine();
            var statistic = new Dictionary<string, Dictionary<string, long>>();
            var stringSeparator = new string[] { " @" };

            while (input != "End")
            {
                var matches = Regex.Matches(input, Pattern);
                if (matches.Count > 0)
                {
                    var line = input.Split(stringSeparator, StringSplitOptions.RemoveEmptyEntries);
                    var singer = line[0].ToString();
                    var line2 = line[1].Split(' ').ToList();

                    var ticketsPrice = long.Parse(line2[line2.Count - 2]);
                    line2.RemoveAt(line2.Count - 2);
                    var ticketsCount = long.Parse(line2[line2.Count - 1]);
                    line2.RemoveAt(line2.Count - 1);
                    string town = string.Join(" ", line2.ToArray());
                    long wins = ticketsCount * ticketsPrice;
                    if (!statistic.ContainsKey(town))
                    {
                        statistic[town] = new Dictionary<string, long>();
                    }

                    if (!statistic[town].ContainsKey(singer))
                    {
                        statistic[town][singer] = wins;
                    }
                    else
                    {
                        statistic[town][singer] += wins;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var city in statistic)
            {
                Console.WriteLine(city.Key);
                foreach (var singer in city.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
