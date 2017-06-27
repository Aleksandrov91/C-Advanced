using System;
using System.Linq;
using System.Text;

namespace Multiply_big_number
{
    public class MultiplyNumber
    {
        public static void Main()
        {
            var number = Console.ReadLine();
            var multiplier = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            var temp = 0;

            if (number == "0" || number == string.Empty || multiplier == 0)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = 0; i < number.Length; i++)
            {
                var currentNum = int.Parse(number[number.Length - 1 - i].ToString());
                var result = (currentNum * multiplier) + temp;
                var stringResult = result.ToString();
                if (result >= 10)
                {
                    sb.Append(stringResult[1]);
                    temp = int.Parse(stringResult[0].ToString());
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

            var multipliedResult = sb.ToString().TrimEnd('0').Reverse();
            Console.WriteLine(string.Join(string.Empty, multipliedResult));
        }
    }
}
