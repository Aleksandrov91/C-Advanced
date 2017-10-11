using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum_big_numbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNum = Console.ReadLine();
            var secondNum = Console.ReadLine();
            var splitedStrings = new List<string>();
            splitedStrings.Add(firstNum);
            splitedStrings.Add(secondNum);
            var longestString = splitedStrings.OrderByDescending(x => x.Length).First();
            var lowerstString = splitedStrings.OrderByDescending(x => x.Length).Last();
            var sb = new StringBuilder();
            var temp = 0;

            for (int i = 0; i < longestString.Length; i++)
            {
                var longestLastChar = int.Parse(longestString[longestString.Length - i - 1].ToString());
                var lowerstLastChar = 0;
                if (i < lowerstString.Length)
                {
                    lowerstLastChar = int.Parse(lowerstString[lowerstString.Length - i - 1].ToString());
                }

                var result = longestLastChar + lowerstLastChar + temp;
                var stringResult = result.ToString();
                if (result >= 10)
                {
                    temp = int.Parse(stringResult[0].ToString());
                    sb.Append(stringResult[1]);
                }
                else
                {
                    sb.Append(stringResult[0]);
                    temp = 0;
                }
            }

            if (temp != 0)
            {
                sb.Append(temp);
            }

            var summedNums = sb.ToString().TrimEnd('0').Reverse();

            Console.WriteLine(string.Join(string.Empty, summedNums));
        }
    }
}
