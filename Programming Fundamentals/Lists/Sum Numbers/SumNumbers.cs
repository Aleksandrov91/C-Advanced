using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Numbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            int sum = 0;
            foreach (var element in input)
            {
                int numberElement = int.Parse(ReverseString(element));
                sum += numberElement;
            }
            Console.WriteLine(sum);
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            //arr.Reverse();
            return new string(arr);
        }

    }
}
