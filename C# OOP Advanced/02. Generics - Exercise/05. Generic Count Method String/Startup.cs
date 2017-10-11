namespace _05.Generic_Count_Method_String
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var list = new List<double>();
            var inputLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputLines; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            var comparer = double.Parse(Console.ReadLine());
            Console.WriteLine(Compare(list, comparer));
        }

        public static int Compare<T>(List<T> elements, T comparer)
            where T : IComparable<T>
        {
            var count = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                if (comparer.CompareTo(elements[i]) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
