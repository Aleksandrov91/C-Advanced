using System;
using System.Collections.Generic;
using System.Linq;

namespace Logs_Aggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var ipAddress = input[0].ToString();
                var userName = input[1].ToString();
                int duration = int.Parse(input[2]);

                if (!logs.ContainsKey(userName))
                {
                    logs[userName] = new SortedDictionary<string, int>();
                }

                if (!logs[userName].ContainsKey(ipAddress))
                {
                    logs[userName][ipAddress] = duration;
                }
                else
                {
                    logs[userName][ipAddress] += duration;
                }
            }

            foreach (var user in logs)
            {
                var userEntry = user.Value;
                var maxDuration = userEntry.Values.Sum();
                Console.Write($"{user.Key}: {maxDuration} [");
                var last = userEntry.Last();
                foreach (var address in userEntry)
                {
                    if (address.Equals(last))
                    {
                        Console.WriteLine($"{address.Key}]");
                    }
                    else
                    {
                        Console.Write($"{address.Key}, ");
                    }                    
                }
            }
        }
    }
}
