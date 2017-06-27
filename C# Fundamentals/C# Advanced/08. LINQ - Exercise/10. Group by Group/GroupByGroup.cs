namespace _10.Group_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GroupByGroup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var persons = new List<Person>();

            while (inputLine != "END")
            {
                var inputData = inputLine.Split(' ');
                persons.Add(new Person
                {
                    Name = inputData[0] + " " + inputData[1],
                    Group = int.Parse(inputData[2])
                });

                inputLine = Console.ReadLine();
            }

            var groupedPersons = persons
                .GroupBy(p => p.Group)
                .OrderBy(g => g.Key);

            foreach (var group in groupedPersons)
            {
                Console.Write(group.Key + " - ");
                var names = new StringBuilder();
                foreach (var person in group)
                {
                    names.Append(person.Name).Append(", ");
                }

                names.Length -= 2;
                Console.WriteLine(names);
            }
        }
    }
}
