namespace _04.Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var numberOfPersons = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int index = 0; index < numberOfPersons; index++)
            {
                var personData = Console.ReadLine().Split(' ');

                persons.Add(new Person(personData[0], int.Parse(personData[1])));
            }

            persons.Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}
