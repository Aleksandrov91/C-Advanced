using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Periodic_Table
{
    public class PeriodicTable
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var uniqueElements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ');

                foreach (var s in input)
                {
                    uniqueElements.Add(s);
                }
            }

            var sb = new StringBuilder();

            foreach (var element in uniqueElements)
            {
                sb.Append(element);
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
