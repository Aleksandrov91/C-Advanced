using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_100_to_Text
{
    class Number100ToText
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string tenths = "";
            string ones = "";
            string teens = "";
            if (num < 0 || num > 100)
                Console.WriteLine("invalid number");

            else if (num > 9 && num < 20)
            {
                if (num == 10)
                    teens = "ten";
                else if (num == 11)
                    teens = "eleven";
                else if (num == 12)
                    teens = "twelve";
                else if (num == 13)
                    teens = "thirteen";
                else if (num == 14)
                    teens = "fourteen";
                else if (num == 15)
                    teens = "fifteen";
                else if (num == 16)
                    teens = "sixteen";
                else if (num == 17)
                    teens = "seventeen";
                else if (num == 18)
                    teens = "eighteen";
                else if (num == 19)
                    teens = "nineteen";
                Console.WriteLine(teens);
            }

            else if (num <= 100)
            {
                var firstDigit = (num / 10) % 10;
                var secondDigit = num % 10;

                if (firstDigit == 2)
                    tenths = "twenty";
                else if (firstDigit == 3)
                    tenths = "thirty";
                else if (firstDigit == 4)
                    tenths = "fourty";
                else if (firstDigit == 5)
                    tenths = "fifty";
                else if (firstDigit == 6)
                    tenths = "sixty";
                else if (firstDigit == 7)
                    tenths = "seventy";
                else if (firstDigit == 8)
                    tenths = "eighty";
                else if (firstDigit == 9)
                    tenths = "ninety";
                else if (num == 100)
                    tenths = "one hundred";

                if (num == 0)
                    ones = "zero";
                else if (secondDigit == 1)
                    ones = "one";
                else if (secondDigit == 2)
                    ones = "two";
                else if (secondDigit == 3)
                    ones = "three";
                else if (secondDigit == 4)
                    ones = "four";
                else if (secondDigit == 5)
                    ones = "five";
                else if (secondDigit == 6)
                    ones = "six";
                else if (secondDigit == 7)
                    ones = "seven";
                else if (secondDigit == 8)
                    ones = "eight";
                else if (secondDigit == 9)
                    ones = "nine";

                if (num < 10)
                    Console.WriteLine(ones);
                else if (num % 10 == 0)
                    Console.WriteLine(tenths);
                else
                    Console.WriteLine("{0} {1}", tenths, ones);
            }
        }
    }
}
