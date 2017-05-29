using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Logs_Aggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var logs = new SortedDictionary<string, SortedDictionary<string, decimal>>();

            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ipAddress = data[0];
                var user = data[1];
                var duration = decimal.Parse(data[2]);

                if (!logs.ContainsKey(user))
                {
                    logs[user] = new SortedDictionary<string, decimal>();
                }

                if (!logs[user].ContainsKey(ipAddress))
                {
                    logs[user][ipAddress] = duration;
                }
                else
                {
                    logs[user][ipAddress] += duration;
                }
            }

            foreach (var log in logs)
            {
                Console.WriteLine($"{log.Key}: {log.Value.Values.Sum()} [{string.Join(", ", log.Value.Select(i => i.Key))}]");
            }
        }
    }
}
