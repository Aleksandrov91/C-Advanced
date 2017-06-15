using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sum_Numbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            Console.WriteLine(Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList()
                .PrintSumAndCount());
        }
    }

    public static class ExtensionMethods
    {
        public static string PrintSumAndCount(this List<int> list)
        {
            return $"{list.Count}\r\n{list.Sum()}";
        }
    }
}
