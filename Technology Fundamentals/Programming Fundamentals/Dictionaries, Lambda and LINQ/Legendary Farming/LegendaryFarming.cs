using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            var uniqueItems = new Dictionary<string, int>();
            uniqueItems["motes"] = 0;
            uniqueItems["fragments"] = 0;
            uniqueItems["shards"] = 0;
            var junkItems = new SortedDictionary<string, int>();
            while (true)
            {
                var line = Console.ReadLine().ToLower().Split();
                for (int i = 1; i < line.Length; i += 2)
                {
                    var quantity = int.Parse(line[i - 1]);
                    var item = line[i].ToString();
                    if (item == "motes" || item == "fragments" || item == "shards")
                    {
                        uniqueItems[item] += quantity;
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(item))
                        {
                            junkItems[item] = quantity;
                        }
                        else
                        {
                            junkItems[item] += quantity;
                        }
                    }

                    if (uniqueItems["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        uniqueItems["motes"] -= 250;
                        PrintItems(uniqueItems, junkItems);
                        return;
                    }
                    else if (uniqueItems["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        uniqueItems["fragments"] -= 250;
                        PrintItems(uniqueItems, junkItems);
                        return;
                    }
                    else if (uniqueItems["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        uniqueItems["shards"] -= 250;
                        PrintItems(uniqueItems, junkItems);
                        return;
                    }
                }
            }
        }

        public static void PrintItems(Dictionary<string, int> uniqueItems, SortedDictionary<string, int> junkItems)
        {
            foreach (var item in uniqueItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
