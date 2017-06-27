namespace _08.Map_Districts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MapDistricts
    {
        public static void Main()
        {
            var line = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var minPopulation = long.Parse(Console.ReadLine());

            var cityPopulation = new Dictionary<string, List<long>>();

            foreach (var s in line)
            {
                var lineArgs = s.Split(':');
                var city = lineArgs[0];
                var population = long.Parse(lineArgs[1]);

                if (!cityPopulation.ContainsKey(city))
                {
                    cityPopulation[city] = new List<long>() { population };
                }
                else
                {
                    cityPopulation[city].Add(population);
                }
            }

            cityPopulation = cityPopulation
                .Where(p => p.Value.Sum() > minPopulation)
                .OrderByDescending(x => x.Value.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var keyValuePair in cityPopulation)
            {
                Console.WriteLine($"{keyValuePair.Key}: {string.Join(" ", keyValuePair.Value.OrderByDescending(x => x).Take(5))}");
            }
        }
    }
}
