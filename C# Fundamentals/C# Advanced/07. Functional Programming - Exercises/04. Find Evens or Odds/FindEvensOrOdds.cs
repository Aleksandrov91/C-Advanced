namespace _04.Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindEvensOrOdds
    {
        public static void Main()
        {
            Predicate<int> evenNumbers = n => n % 2 == 0;

            var range = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            var type = Console.ReadLine();

            PrintNumbers(range, type, evenNumbers);
        }

        public static void PrintNumbers(int[] range, string type, Predicate<int> evenNumbers)
        {
            var result = new List<int>();
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (type == "even" && evenNumbers(i))
                {
                    result.Add(i);
                }
                else if (type == "odd" && !evenNumbers(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
