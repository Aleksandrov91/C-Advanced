namespace _13.TriFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TriFunction
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>();
            Func<string, int, bool> checkSum = (x, y) => x.ToCharArray().Select(ch => (int)ch).Sum() >= n;
            Func<string[], Func<string, int, bool>, string> validName =
                (strings, func) => strings.FirstOrDefault(str => func(str, n));

            var name = validName(names, checkSum);

            Console.WriteLine(name);
        }
    }
}
