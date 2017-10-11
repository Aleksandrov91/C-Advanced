namespace _10.Predicate_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PredicateParty
    {
        public static void Main()
        {
            var guests = Console.ReadLine().Split(' ').ToList();
            var line = Console.ReadLine();
            var filteredGuests = new List<string>(guests);

            Func<string, string, bool> startsWith = (x, y) => x.Substring(0, y.Length) == y;
            Func<string, string, bool> endsWith = (x, y) => x.Substring(x.Length - y.Length) == y;
            Func<string, string, bool> length = (x, y) => x.Length == int.Parse(y);

            while (line != "Party!")
            {
                var lineArgs = line.Split(' ');
                var command = lineArgs[0];
                var criteria = lineArgs[1];
                var data = lineArgs[2];

                if (command == "Remove")
                {
                    if (criteria == "StartsWith")
                    {
                        RemoveGuests(guests, filteredGuests, data, startsWith);
                    }
                    else if (criteria == "EndsWith")
                    {
                        RemoveGuests(guests, filteredGuests, data, endsWith);
                    }
                    else
                    {
                        RemoveGuests(guests, filteredGuests, data, length);
                    }
                }
                else if (command == "Double")
                {
                    if (criteria == "StartsWith")
                    {
                        AddGuests(guests, filteredGuests, data, startsWith);
                    }
                    else if (criteria == "EndsWith")
                    {
                        AddGuests(guests, filteredGuests, data, endsWith);
                    }
                    else
                    {
                        AddGuests(guests, filteredGuests, data, length);
                    }
                }

                line = Console.ReadLine();
            }

            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
                return;
            }

            Console.WriteLine(string.Join(", ", filteredGuests) + " are going to the party!");
        }

        public static void AddGuests(List<string> guests, List<string> filteredGuests, string data, Func<string, string, bool> filter)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                if (filter(guests[i], data))
                {
                    filteredGuests.Insert(i, guests[i]);
                }
            }

            guests.Clear();
            guests.AddRange(filteredGuests);
        }

        public static void RemoveGuests(List<string> guests, List<string> filteredGuests, string data, Func<string, string, bool> filter)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                if (filter(guests[i], data))
                {
                    filteredGuests.Remove(guests[i]);
                }
            }

            guests.Clear();
            guests.AddRange(filteredGuests);
        }
    }
}
