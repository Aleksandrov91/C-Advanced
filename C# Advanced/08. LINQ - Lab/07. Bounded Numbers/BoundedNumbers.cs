namespace _07.Bounded_Numbers
{
    using System;
    using System.Linq;

    public class BoundedNumbers
    {
        public static void Main()
        {
            var boundary = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToArray();
            var lowerBound = boundary[0];
            var upperBound = boundary[1];
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(n => n >= lowerBound && n <= upperBound)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
