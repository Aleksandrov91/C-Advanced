using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Miner_Task
{
    public class MinerTask
    {
        public static void Main()
        {
            var type = Console.ReadLine();
            var resources = new Dictionary<string, int>();
            var temp = new List<string>();
            while (!type.Equals("stop"))
            {
                int count = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(type))
                {
                    resources[type] = count;
                }

                resources[type] += count;
                type = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}