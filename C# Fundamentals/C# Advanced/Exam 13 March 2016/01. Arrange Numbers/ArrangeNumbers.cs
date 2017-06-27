using System;
using System.Text;

namespace _01.Arrange_Numbers
{
    public class ArrangeNumbers
    {
        public static void Main()
        {
            var numbersToSort = Console.ReadLine()
                .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            var numbersAsText = new string[numbersToSort.Length];

            for (int i = 0; i < numbersAsText.Length; i++)
            {
                var currentNum = numbersToSort[i];

                if (currentNum.Length > 1)
                {
                    var sb = new StringBuilder();

                    for (int j = 0; j < currentNum.Length; j++)
                    {
                        sb.Append(ConvertToString(currentNum[j].ToString())).Append("-");
                    }

                    numbersAsText[i] = sb.ToString().Trim('-');
                }
                else
                {
                    numbersAsText[i] = ConvertToString(currentNum);
                }

            }

            Array.Sort(numbersAsText);

            for (int i = 0; i < numbersAsText.Length; i++)
            {
                numbersAsText[i] = ConvertToNumbers(numbersAsText[i]);
            }

            Console.WriteLine(string.Join(", ", numbersAsText));
        }

        private static string ConvertToNumbers(string numbersAsText)
        {
            var result = new StringBuilder();
            var dd = numbersAsText.Split('-');

            for (int i = 0; i < dd.Length; i++)
            {
                switch (dd[i])
                {
                    case "zero":
                        result.Append("0");
                        break;
                    case "one":
                        result.Append("1");
                        break;
                    case "two":
                        result.Append("2");
                        break;
                    case "three":
                        result.Append("3");
                        break;
                    case "four":
                        result.Append("4");
                        break;
                    case "five":
                        result.Append("5");
                        break;
                    case "six":
                        result.Append("6");
                        break;
                    case "seven":
                        result.Append("7");
                        break;
                    case "eight":
                        result.Append("8");
                        break;
                    case "nine":
                        result.Append("9");
                        break;
                }
            }

            return result.ToString();
        }

        private static string ConvertToString(string number)
        {
            var numberAsText = string.Empty;
            switch (number)
            {
                case "0":
                    numberAsText = "zero";
                    break;
                case "1":
                    numberAsText = "one";
                    break;
                case "2":
                    numberAsText = "two";
                    break;
                case "3":
                    numberAsText = "three";
                    break;
                case "4":
                    numberAsText = "four";
                    break;
                case "5":
                    numberAsText = "five";
                    break;
                case "6":
                    numberAsText = "six";
                    break;
                case "7":
                    numberAsText = "seven";
                    break;
                case "8":
                    numberAsText = "eight";
                    break;
                case "9":
                    numberAsText = "nine";
                    break;
            }

            return numberAsText;
        }
    }
}
