namespace _07.Equality_Logic
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var sortedPersons = new SortedSet<Person>(new NameComparer());
            var hashPersons = new HashSet<Person>();

            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var person = new Person(input[0], int.Parse(input[1]));

                if (!hashPersons.Equals(person))
                {
                    hashPersons.Add(person);
                }

                sortedPersons.Add(person);
            }

            Console.WriteLine(sortedPersons.Count);
            Console.WriteLine(hashPersons.Count);
        }
    }
}
