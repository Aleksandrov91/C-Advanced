namespace _06.Strategy_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Strategy;

    public class Startup
    {
        public static void Main()
        {
            var persons = new SortedList();

            //var nameSortCollection = new SortedSet<Person>(new NameComparer());
            //var ageSortCollection = new SortedSet<Person>(new AgeComparer());

            var inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var person = new Person(input[0], int.Parse(input[1]));
                persons.Add(person);
                //nameSortCollection.Add(person);
                //ageSortCollection.Add(person);
            }

            persons.SetSortStrategy(new NameSort());
            persons.Sort();

            foreach (var person in persons.Distinct())
            {
                Console.WriteLine(person);
            }

            persons.SetSortStrategy(new AgeSort());
            persons.Sort();

            foreach (var person in persons.Distinct())
            {
                Console.WriteLine(person);
            }

            //foreach (var person in nameSortCollection)
            //{
            //    Console.WriteLine(person);
            //}

            //foreach (var person in ageSortCollection)
            //{
            //    Console.WriteLine(person);
            //}
        }
    }
}
