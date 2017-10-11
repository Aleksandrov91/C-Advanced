namespace _06.Find_and_Sum_Integers
{
    using System;
    using System.Linq;

    public class FindAndSumIntegers
    {
        public static void Main()
        {
            var result = 0L;
            var numbers = Console.ReadLine()
                .Split(' ')
                .Where(n => long.TryParse(n, out result))
                .Select(long.Parse)
                .ToList();

            if (numbers.Count != 0)
            {
                Console.WriteLine(numbers.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
