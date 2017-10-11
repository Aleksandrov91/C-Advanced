namespace _06.Reverse_And_Exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var divider = int.Parse(Console.ReadLine());

            Predicate<int> checkIsDivide = n => n % divider != 0;
            CheckAndPrint(numbers, checkIsDivide);
        }

        public static void CheckAndPrint(int[] numbers, Predicate<int> checkIsDivide)
        {
            var result = new List<int>();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (checkIsDivide(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
