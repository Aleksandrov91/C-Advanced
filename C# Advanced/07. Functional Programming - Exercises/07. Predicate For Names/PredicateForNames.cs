using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Predicate_For_Names
{
    public class PredicateForNames
    {
        public static void Main()
        {
            var length = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split(' ');

            Predicate<string> filterName = w => w.Length <= length;
            FilterNames(names, filterName);
        }

        public static void FilterNames(string[] names, Predicate<string> filter)
        {
            foreach (var name in names)
            {
                if (filter(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
