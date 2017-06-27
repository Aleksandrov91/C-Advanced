namespace _09.List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListOfPredicates
    {
        public static void Main()
        {
            var range = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();
            var isDivider = true;

            for (int i = 1; i <= range; i++)
            {
                for (int j = 0; j < dividers.Count; j++)
                {
                    if (i % dividers[j] != 0)
                    {
                        isDivider = false;
                        break;
                    }
                }

                if (isDivider)
                {
                    result.Add(i);
                }

                isDivider = true;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
