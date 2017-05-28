using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Population_Counter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var population = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                var args = input.Split('|');
                var city = args[0];
                var country = args[1];
                var populationCount = long.Parse(args[2]);

                if (!population.ContainsKey(country))
                {
                    population[country] = new Dictionary<string, long>();
                }

                if (!population[country].ContainsKey(city))
                {
                    population[country][city] = populationCount;
                }
                else
                {
                    population[country][city] += populationCount;
                }

                input = Console.ReadLine();
            }

            foreach (var country in population.OrderByDescending(x => x.Value.Sum(a => a.Value)))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(a => a.Value)})");

                Console.WriteLine("{0}", string.Join("\r\n", country.Value.OrderByDescending(p => p.Value).Select(a => $"=>{a.Key}: {a.Value}")));
            }
        }
    }
}
