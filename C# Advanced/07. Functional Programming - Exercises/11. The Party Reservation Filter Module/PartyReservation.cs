namespace _11.The_Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PartyReservation
    {
        public static void Main()
        {
            var guests = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var filterParams = Console.ReadLine();
            var commands = new List<string>();

            Func<string, string, bool> startsWith = (x, y) => x.Substring(0, y.Length) == y;
            Func<string, string, bool> endsWith = (x, y) => x.Substring(x.Length - y.Length) == y;
            Func<string, string, bool> length = (x, y) => x.Length == int.Parse(y);
            Func<string, string, bool> contains = (x, y) => x.Contains(y);

            while (filterParams != "Print")
            {
                var filterArgs = filterParams.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var command = filterArgs[0];
                var filterType = filterArgs[1];
                var filterParam = filterArgs[2];

                if (command == "Add filter")
                {
                    commands.Add(filterType + ";" + filterParam);
                }
                else if (command == "Remove filter")
                {
                    commands.Remove(filterType + ";" + filterParam);
                }

                filterParams = Console.ReadLine();
            }

            foreach (var command in commands)
            {
                var line = command.Split(';');
                switch (line[0])
                {
                    case "Starts with":
                        guests = RemoveFromGuestList(guests, startsWith, line[1]);
                        break;
                    case "Ends with":
                        guests = RemoveFromGuestList(guests, endsWith, line[1]);
                        break;
                    case "Length":
                        guests = RemoveFromGuestList(guests, length, line[1]);
                        break;
                    case "Contains":
                        guests = RemoveFromGuestList(guests, contains, line[1]);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", guests));
        }

        private static List<string> RemoveFromGuestList(List<string> guests, Func<string, string, bool> filter, string filterParam)
        {
            for (var i = 0; i < guests.Count; i++)
            {
                if (filter(guests[i], filterParam))
                {
                    guests.Remove(guests[i]);
                    i--;
                }
            }

            return guests;
        }
    }
}
