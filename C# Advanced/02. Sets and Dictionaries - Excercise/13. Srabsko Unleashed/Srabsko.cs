using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Srabsko_Unleashed
{
    public class Srabsko
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var venueData = new Dictionary<string, Dictionary<string, long>>();

            while (input != "End")
            {
                var inputArgs = input.Split(new[] {" @"}, StringSplitOptions.RemoveEmptyEntries);

                if (inputArgs.Length != 2)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var singer = inputArgs[0];
                var venueInfo = inputArgs[1].Split(' ');

                if (venueInfo.Length < 3)
                {
                    input = Console.ReadLine();
                    continue;
                }

                long ticketsCount = 0;
                long ticketsPrice = 0;

                try
                {
                    ticketsPrice = long.Parse(venueInfo[venueInfo.Length - 2]);
                    ticketsCount = long.Parse(venueInfo[venueInfo.Length - 1]);
                }
                catch (Exception e)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var venue = string.Empty;

                for (int i = 0; i < venueInfo.Length - 2; i++)
                {
                    venue += venueInfo[i] + " ";
                }

                venue = venue.Trim();
                if (!venueData.ContainsKey(venue))
                {
                    venueData[venue] = new Dictionary<string, long>();
                }

                if (!venueData[venue].ContainsKey(singer))
                {
                    venueData[venue][singer] = ticketsCount * ticketsPrice;
                }
                else
                {
                    venueData[venue][singer] += ticketsPrice * ticketsCount;
                }

                input = Console.ReadLine();
            }

            foreach (var venue in venueData)
            {
                Console.WriteLine(venue.Key);
                Console.WriteLine("#  {0}", string.Join("\r\n#  ", venue.Value.OrderByDescending(x => x.Value).Select(s => $"{s.Key} -> {s.Value}")));
            }
        }
    }
}
