using System;
using System.Collections.Generic;

namespace _06.A_Miner_Task
{
    public class AMinerTask
    {
        public static void Main()
        {
            var resources = Console.ReadLine();

            var miner = new Dictionary<string, decimal>();

            while (resources != "stop")
            {
                var quantity = decimal.Parse(Console.ReadLine());

                if (!miner.ContainsKey(resources))
                {
                    miner[resources] = quantity;
                }
                else
                {
                    miner[resources] += quantity;
                }

                resources = Console.ReadLine();
            }

            foreach (var kvp in miner)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
