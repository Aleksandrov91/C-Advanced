using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Sum_big_numbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();

            string result = SumNumbers(firstNum, secondNum);

            Console.WriteLine(result.TrimStart('0'));
        }

        private static string SumNumbers(string firstNum, string secondNum)
        {
            Stack<int> firstNumStack = new Stack<int>(firstNum.ToCharArray().Select(n => (int) char.GetNumericValue(n)));
            Stack<int> secondNumStack = new Stack<int>(secondNum.ToCharArray().Select(n => (int) char.GetNumericValue(n)));
            StringBuilder result = new StringBuilder();
            int sumCurrentNums = 0;
            while (firstNumStack.Count != 0 || secondNumStack.Count != 0)
            {
                if (firstNumStack.Count != 0)
                {
                    sumCurrentNums += firstNumStack.Pop();
                }

                if (secondNumStack.Count != 0)
                {
                    sumCurrentNums += secondNumStack.Pop();
                }

                result.Insert(0, sumCurrentNums % 10);

                sumCurrentNums = sumCurrentNums / 10;
            }

            result.Insert(0, sumCurrentNums);
            return result.ToString();
        }
    }
}
