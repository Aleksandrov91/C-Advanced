using System;
using System.Collections.Generic;
using System.Linq;

namespace User_Logs
{
    public class UserLogs
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            while (input != "end")
            {
                var line = input.Split();
                string[] ipSeparators = new string[] { "IP=" };
                var ip = line[0].Split(ipSeparators, StringSplitOptions.RemoveEmptyEntries);
                string[] userNameSeparators = new string[] { "user=" };
                var userName = line[2].Split(userNameSeparators, StringSplitOptions.RemoveEmptyEntries);



                if (!users.ContainsKey(userName[0]))
                {
                    users[userName[0]] = new Dictionary<string, int>();
                }

                if (!users[userName[0]].ContainsKey(ip[0]))
                {
                    users[userName[0]][ip[0]] = 1;
                }
                else
                {
                    users[userName[0]][ip[0]]++;
                }

                input = Console.ReadLine();
            }

            foreach (var user in users)
            {
                var userAcc = user.Key;
                var userIP = user.Value;
                Console.WriteLine($"{userAcc}: ");
                var last = userIP.Last();
                foreach (var ip in userIP)
                {
                    var address = ip.Key;
                    var count = ip.Value;
                    if (ip.Equals(last))
                    {
                        Console.WriteLine($"{address} => {count}.");
                    }
                    else
                    {
                        Console.Write($"{address} => {count}, ");
                    }
                }
            }
        }
    }
}
