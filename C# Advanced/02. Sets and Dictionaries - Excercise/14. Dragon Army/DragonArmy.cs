using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.Dragon_Army
{
    public class DragonArmy
    {
        private const int DefaultDamage = 45;
        private const int DefaultHealth = 250;
        private const int DefaultArmor = 10;
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dragonArmy = new Dictionary<string, SortedDictionary<string, int[]>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var dragonType = input[0];
                var dragonName = input[1];
                var damage = input[2].Equals("null") ? DefaultDamage : int.Parse(input[2]);
                var health = input[3].Equals("null") ? DefaultHealth : int.Parse(input[3]);
                var armor = input[4].Equals("null") ? DefaultArmor : int.Parse(input[4]);

                if (!dragonArmy.ContainsKey(dragonType))
                {
                    dragonArmy[dragonType] = new SortedDictionary<string, int[]>();
                }

                if (!dragonArmy[dragonType].ContainsKey(dragonName))
                {
                    dragonArmy[dragonType][dragonName] = new int[3];
                }

                dragonArmy[dragonType][dragonName] = new[] {damage, health, armor};
            }

            foreach (var type in dragonArmy)
            {
                var averageDamage = type.Value.Values.Average(x => x[0]);
                var averageHealth = type.Value.Values.Average(x => x[1]);
                var averageArmor = type.Value.Values.Average(x => x[2]);
                Console.WriteLine($"{type.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
