using System;
using System.Collections.Generic;

namespace _01.Unique_Usernames
{
    public class UniqueUsernames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var userNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var userName = Console.ReadLine();
                userNames.Add(userName);
            }

            foreach (var userName in userNames)
            {
                Console.WriteLine(userName);
            }
        }
    }
}
