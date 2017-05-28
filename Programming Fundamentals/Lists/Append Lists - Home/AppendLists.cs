using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Lists___Home
{
    public class AppendLists
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var separatedList = input.Split('|').ToArray();
            var result = new List<int>();
            for (int index = separatedList.Length - 1; index >= 0 ; index--)
            {
                List<int> currentList = separatedList[index]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                for (int current = 0; current < currentList.Count; current++)
                {
                    result.Add(currentList[current]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
