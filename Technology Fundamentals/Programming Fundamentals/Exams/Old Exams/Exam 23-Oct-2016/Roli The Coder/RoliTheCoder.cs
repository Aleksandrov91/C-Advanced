using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Roli_The_Coder
{
    public class RoliTheCoder
    {
        public static void Main()
        {
            var regex = new Regex(@"[0-9]\s#[A-Za-z0-9]+");
            var input = Console.ReadLine();
            var result = new HashSet<Organizer>();

            while (input != "Time for Code")
            {
                var match = regex.Match(input);
                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var line = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var id = int.Parse(line.First());
                var eventName = line[1].TrimStart('#');
                var participants = line.Skip(2).ToArray();
                var newEntry = new Organizer
                {
                    ID = id,
                    Name = eventName,
                    Participants = new HashSet<string>(participants)
                };

                if (result.Any(i => i.ID == id))
                {
                    var current = result.FirstOrDefault(e => e.ID == id);

                    if (current.Name == eventName)
                    {
                        foreach (var participant in participants)
                        {
                            current.Participants.Add(participant);
                        }
                    }
                }
                else
                {
                    result.Add(newEntry);
                }

                input = Console.ReadLine();
            }

            foreach (var item in result
                .OrderByDescending(p => p.Participants.Count)
                .ThenBy(a => a.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Participants.Count}");
                foreach (var participant in item.Participants
                    .OrderBy(a => a))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }

    public class Organizer
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public HashSet<string> Participants { get; set; }
    }
}
