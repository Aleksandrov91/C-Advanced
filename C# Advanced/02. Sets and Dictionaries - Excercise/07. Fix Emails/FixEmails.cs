using System;
using System.Collections.Generic;

namespace _07.Fix_Emails
{
    public class FixEmails
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var emailBook = new Dictionary<string, string>();

            while (name != "stop")
            {
                var email = Console.ReadLine();

                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    name = Console.ReadLine();
                    continue;
                }

                if (!emailBook.ContainsKey(name))
                {
                    emailBook[name] = email;
                }
                else
                {
                    emailBook[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var kvp in emailBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
