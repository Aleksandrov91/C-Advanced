using System;
using System.Collections.Generic;
using System.Linq;

namespace Fix_Emails
{
    public class FixEmails
    {
        public static void Main()
        {
            var emailBook = new Dictionary<string, string>();
            string name = Console.ReadLine();
            while (!name.Equals("stop"))
            {
                string email = Console.ReadLine();

                if (!emailBook.ContainsKey(name) && !email.Contains("us") || !email.Contains("uk"))
                {
                    emailBook[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var email in emailBook)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}
