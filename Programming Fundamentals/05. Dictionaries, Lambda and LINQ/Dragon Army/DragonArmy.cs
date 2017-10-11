using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    public class DragonArmy
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var type = input[0];
                var name = input[1];
                var damage = 0;
                if (input[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(input[2]);
                }

                var health = 0;
                if (input[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(input[3]);
                }

                var armor = 0;
                if (input[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(input[4]);
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, List<int>>();
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new List<int>();
                    dragons[type][name].Add(damage);
                    dragons[type][name].Add(health);
                    dragons[type][name].Add(armor);
                }
                else
                {
                    dragons[type][name].Clear();
                    dragons[type][name].Add(damage);
                    dragons[type][name].Add(health);
                    dragons[type][name].Add(armor);
                }
            }

            foreach (var type in dragons)
            {
                var dragonsName = type.Value;
                var averageDamage = type.Value.Values.Average(x => x[0]);
                var averageHealth = type.Value.Values.Average(x => x[1]);
                var averageArmor = type.Value.Values.Average(x => x[2]);

                Console.WriteLine($"{type.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");
                foreach (var name in dragonsName)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }            
            }
        }
    }
}
