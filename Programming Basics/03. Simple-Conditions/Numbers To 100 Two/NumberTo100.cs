using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_To_100_Two
{
    class NumberTo100
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            string firstWord = "";
            string secWord = "";
            string lastWord = "";

            switch (secWord)
            {
                case 0:
                    secWord = "zero";
                    break;
                case 1:
                    secWord = "one";
                    break;
                case 2:
                    secWord = "two";
                    break;
                case 3:
                    secWord = "Three";
                    break;
                case 4:
                    secWord = "four";
                    break;
                case 5:
                    secWord = "five";
                    break;
                case 6:
                    secWord = "six";
                    break;
                case 7:
                    secWord = "seven";
                    break;
                case 8:
                    secWord = "eight";
                    break;
                case 9:
                    secWord = "nine";
                    break;
                default:
                    break;
            }
            switch (firstWord)
            {
                case 1:
                    secWord = "one";
                    break;
                case 2:
                    secWord = "two";
                    break;
                case 3:
                    secWord = "Three";
                    break;
                case 4:
                    secWord = "four";
                    break;
                case 5:
                    secWord = "five";
                    break;
                case 6:
                    secWord = "six";
                    break;
                case 7:
                    secWord = "seven";
                    break;
                case 8:
                    secWord = "eight";
                    break;
                case 9:
                    secWord = "nine";
                    break;
                default:
                    break;
            }

        }
    }
}
