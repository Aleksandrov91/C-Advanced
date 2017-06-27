namespace _04.Convert_from_base_10_to_base_N
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class ConvertToBase
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var baseN = int.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);

            var stack = ConvertNumber(baseN, number);

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
        }

        private static Stack<string> ConvertNumber(int baseN, BigInteger number)
        {
            var convertedNum = new Stack<string>();
            while (number != 0)
            {
                convertedNum.Push((number % baseN).ToString());
                number = number / baseN;
            }

            return convertedNum;
        }
    }
}
