using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_Element
{
    public class MaximumElement
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxElement = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var query = Console.ReadLine()
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                switch (query[0])
                {
                    case 1:
                        if (query[1] > maxElement)
                        {
                            maxElement = query[1];
                        }

                        stack.Push(query[1]);
                        break;
                    case 2:
                        if (stack.Count == 0)
                        {
                            continue;
                        }

                        var currentElement = stack.Pop();

                        if (currentElement == maxElement)
                        {
                            maxElement = stack.Max();
                        }

                        break;
                    case 3:
                        Console.WriteLine(maxElement);
                        break;
                }
            }
        }
    }
}
