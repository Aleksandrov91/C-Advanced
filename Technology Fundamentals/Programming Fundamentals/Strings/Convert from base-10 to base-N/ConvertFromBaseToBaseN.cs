using System;
using System.Collections.Generic;
using System.Numerics;

namespace Convert_from_base_10_to_base_N
{
    public class ConvertFromBaseToBaseN
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var baseNum = int.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);
            var result = new List<BigInteger>();
            while (number > 0)
            {
                var newNum = number % baseNum;
                result.Add(newNum);
                number = number / baseNum;
            }

            result.Reverse();
            Console.WriteLine(string.Join(string.Empty, result));
        }
    }
}
