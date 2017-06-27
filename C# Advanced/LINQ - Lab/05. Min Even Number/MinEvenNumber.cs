namespace _05.Min_Even_Number
{
    using System;
    using System.Linq;

    public class MinEvenNumber
    {
        public static void Main()
        {
            var smallestNum = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .FirstOrDefault();

            if (smallestNum == 0)
            {
                Console.WriteLine("No match");
                return;
            }

            Console.WriteLine($"{smallestNum:F2}");
        }
    }
}
