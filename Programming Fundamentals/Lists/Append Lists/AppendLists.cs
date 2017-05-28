using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Lists
{
    public class AppendLists
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<string> parts = input.Split('|').ToList();

            List<int> resultList = new List<int>();

            for (int partsIndex = parts.Count() - 1; partsIndex >= 0; partsIndex--)
            {
                List<int> currentList = parts[partsIndex]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int currentListIndex = 0; currentListIndex < currentList.Count(); currentListIndex++)
                {
                    resultList.Add(currentList[currentListIndex]);
                    // CTRL+R+R renames
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
