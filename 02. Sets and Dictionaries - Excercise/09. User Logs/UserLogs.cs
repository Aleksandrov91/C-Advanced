using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.User_Logs
{
    public class UserLogs
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var logs = new Dictionary<string, IPLogs>();

            while (input != "end")
            {
                var args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ipAddress = args[0].Substring(3);
                var user = args[2].Split('=').Last();

                if (!logs.ContainsKey(user))
                {
                    logs[user] = new IPLogs
                    {
                        Log = new Dictionary<string, int>()
                    };
                }

                if (!logs[user].Log.ContainsKey(ipAddress))
                {
                    logs[user].Log.Add(ipAddress, 1);
                }
                else
                {
                    logs[user].Log[ipAddress]++;
                }

                input = Console.ReadLine();
            }

            foreach (var user in logs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}:");

                Console.WriteLine("{0}.", string.Join(", ", user.Value.Log.Select(a => $"{a.Key} => {a.Value}")));
            }
        }
    }
}
