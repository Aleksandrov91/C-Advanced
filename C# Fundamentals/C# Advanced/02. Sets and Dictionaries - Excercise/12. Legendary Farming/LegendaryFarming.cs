using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Legendary_Farming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var tokens = new SortedDictionary<string, int>{{"shards", 0}, {"fragments", 0}, {"motes", 0}};
            var junkItems = new SortedDictionary<string, int>();
            var isCollected = false;
            var winingItem = string.Empty;

            while (true)
            {
                var inputArgs = input.ToLower()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < inputArgs.Length - 1; i+=2)
                {
                    var quantity = int.Parse(inputArgs[i]);
                    var currentItem = inputArgs[i + 1];

                    if (tokens.ContainsKey(currentItem))
                    {
                        tokens[currentItem] += quantity;

                        if (tokens[currentItem] >= 250)
                        {
                            isCollected = true;
                            tokens[currentItem] -= 250;
                            winingItem = currentItem;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(currentItem))
                        {
                            junkItems[currentItem] = 0;
                        }

                        junkItems[currentItem] += quantity;
                    }
                }

                if (isCollected)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (winingItem == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (winingItem == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            foreach (var token in tokens.OrderByDescending(t => t.Value))
            {
                Console.WriteLine($"{token.Key}: {token.Value}");
            }

            foreach (var junkItem in junkItems)
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
        }
    }
}
