namespace _01.Generic_Box_of_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var data = new List<Box<int>>();

            var inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                var box = new Box<int>(int.Parse(Console.ReadLine()));
                data.Add(box);
            }

            var swapInexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Swap(data, swapInexes[0], swapInexes[1]);

            foreach (var box in data)
            {
                Console.WriteLine(box.ToString());
            }
        }

        public static void Swap<T>(List<T> elements, int firstPosition, int secondPosition)
        {
            var temp = elements[firstPosition];
            elements[firstPosition] = elements[secondPosition];
            elements[secondPosition] = temp;
        }
    }
}
