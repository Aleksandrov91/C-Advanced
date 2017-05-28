using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var populationReport = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                var line = input.Split('|');
                var city = line[0];
                var country = line[1];
                var population = long.Parse(line[2]);

                if (!populationReport.ContainsKey(country))
                {
                    populationReport[country] = new Dictionary<string, long>();
                }

                if (!populationReport[country].ContainsKey(city))
                {
                    populationReport[country][city] = population;
                }

                input = Console.ReadLine();
            }

            foreach (var item in populationReport.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var country = item.Key;
                var cities = item.Value;
                long maxcount = cities.Values.Sum();
                Console.WriteLine($"{country} (total population: {maxcount})");
                foreach (var element in cities.OrderByDescending(x => x.Value))
                {
                    var city = element.Key;
                    long population = element.Value;
                    Console.WriteLine($"=>{city}: {population}");
                }
            }
        }
    }
}
