using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hornet_Armada
{
    public class HornetArmada
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            //var regex = new Regex(@"(\d+)\s=\s([^\=\-\>\,\;\.\:\s]+)\s->\s([^\=\-\>\,\;\.\:\s]+):(\d+)");
            var regex = new Regex(@"(\d+)\s\=\s(.+)\s\-\>\s(.+)\:(\d+)");
            var result = new Dictionary<string, Hornets>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var match = regex.Match(input);
                if (match.Success)
                {
                    var lastActivity = long.Parse(match.Groups[1].Value.Trim());
                    var legionName = match.Groups[2].Value.Trim();
                    var soldierType = match.Groups[3].Value.Trim();
                    var soldierCount = long.Parse(match.Groups[4].Value.Trim());

                    var hornet = new Hornets
                    {
                        LastActivity = lastActivity,
                        Soldiers = new Dictionary<string, long>()
                    };
                    hornet.Soldiers.Add(soldierType, soldierCount);

                    if (!result.ContainsKey(legionName))
                    {
                        result[legionName] = new Hornets();
                        result[legionName] = hornet;
                    }
                    else
                    {
                        if (result[legionName].LastActivity < lastActivity)
                        {
                            result[legionName].LastActivity = lastActivity;
                        }

                        if (!result[legionName].Soldiers.ContainsKey(soldierType))
                        {
                            result[legionName].Soldiers[soldierType] = soldierCount;
                        }
                        else
                        {
                            result[legionName].Soldiers[soldierType] += soldierCount;
                        }
                    }
                }
            }

            var final = Console.ReadLine();

            if (final.Contains("\\"))
            {
                var split = final.Split('\\');
                var activity = int.Parse(split[0].Trim());
                var soldierType = split[1].Trim();
                foreach (var item in result.OrderByDescending(x => x.Value.Soldiers[soldierType]))
                {
                    var key = item.Key;
                    var value = item.Value;
                    if (value.LastActivity < activity /*&& value.Soldiers.ContainsKey(soldierType)*/)
                    {
                        Console.WriteLine($"{item.Key} -> {value.Soldiers[soldierType]}");
                    }
                }
            }
            else
            {
                foreach (var item in result.OrderByDescending(x => x.Value.LastActivity))
                {
                    if (item.Value.Soldiers.ContainsKey(final))
                    {
                        Console.WriteLine($"{item.Value.LastActivity} : {item.Key}");
                    }
                }
            }
        }
    }

    public class Hornets
    {
        public long LastActivity { get; set; }

        public Dictionary<string, long> Soldiers { get; set; }
    }
}
