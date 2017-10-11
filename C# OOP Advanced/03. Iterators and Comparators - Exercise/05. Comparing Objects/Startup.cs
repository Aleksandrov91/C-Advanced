namespace _05.Comparing_Objects
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var persons = new List<Person>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var inputArgs = input.Split(' ');
                var person = new Person(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]);
                persons.Add(person);
            }

            var indexOfPersonToCompare = int.Parse(Console.ReadLine());

            var equalPeople = 0;
            var notEqualPeople = 0;

            if (indexOfPersonToCompare < persons.Count)
            {
                foreach (var person in persons)
                {
                    var result = person.CompareTo(persons[indexOfPersonToCompare]);

                    if (result == 0)
                    {
                        equalPeople++;
                    }
                    else
                    {
                        notEqualPeople++;
                    }
                }
            }

            Console.WriteLine(equalPeople != 0 ? $"{equalPeople} {notEqualPeople} {persons.Count}" : "No matches");
        }
    }
}
