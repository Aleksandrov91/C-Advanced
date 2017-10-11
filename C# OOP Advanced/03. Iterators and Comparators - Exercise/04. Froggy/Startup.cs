namespace _04.Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new []{' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var lake = new Lake(input);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
