using System;
using System.Collections.Generic;
using System.Linq;

namespace Hornet_Assault
{
    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            var hornets = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var result = new List<long>();

            long hornetsPower = hornets.Sum();

            for (int i = 0; i < beehives.Length; i++)
            {
                if (hornets.Count == 0)
                {
                    result.AddRange(beehives.Skip(i));
                    break;
                }

                var currentBees = beehives[i];
                if (hornetsPower < currentBees)
                {
                    result.Add(currentBees - hornetsPower);
                    hornets.RemoveAt(0);
                    hornetsPower = hornets.Sum();
                }
                else if (hornetsPower == currentBees)
                {
                    hornets.RemoveAt(0);
                    hornetsPower = hornets.Sum();
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
