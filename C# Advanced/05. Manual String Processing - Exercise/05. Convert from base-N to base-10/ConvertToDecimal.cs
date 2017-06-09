using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace _05.Convert_from_base_N_to_base_10
{
    class ConvertToDecimal
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var baseN = int.Parse(input[0]);
            var numToConvert = input[1];

            //var result = ConvertNumber(baseN, numToConvert);
            var result = ConvertNumberWithStack(baseN, numToConvert);
            Console.WriteLine(result);
        }

        private static BigInteger ConvertNumberWithStack(int baseN, string numToConvert)
        {
            var digits = new Stack<int>(numToConvert.ToCharArray().Select(a => (int)char.GetNumericValue(a)));
            BigInteger result = 0;
            int power = 0;
            while (digits.Count != 0)
            {
                var lastDigit = digits.Pop();
                result += RaiseToPower(baseN, power) * lastDigit;
                power++;
            }

            return result;
        }

        private static BigInteger ConvertNumber(int baseN, string numToConvert)
        {
            BigInteger result = 0;
            for (int i = 0; i < numToConvert.Length; i++)
            {
                var currentNum = int.Parse(numToConvert[numToConvert.Length - i - 1].ToString());
                result += RaiseToPower(baseN, i) * currentNum;
            }

            return result;
        }

        private static BigInteger RaiseToPower(int baseN, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                BigInteger result = 1;
                for (int i = 1; i <= power; i++)
                {
                    result *= baseN;
                }

                return result;
            }
        }
    }
}
