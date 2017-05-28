using System;
using System.Text;

namespace Letters_Change_Numbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var stringNum = new StringBuilder();
            var result = 0.0M;

            for (int i = 0; i < input.Length; i++)
            {
                var currentString = input[i];

                for (int j = 0; j < currentString.Length; j++)
                {
                    var currentChar = currentString[j];
                    if (char.IsDigit(currentChar))
                    {
                        stringNum.Append(currentChar.ToString());
                    }
                }

                var number = decimal.Parse(stringNum.ToString());
                stringNum.Clear();

                var firstChar = currentString[0];
                var secondChar = currentString[currentString.Length - 1];

                if (char.IsUpper(firstChar))
                {
                    number = number / int.Parse((firstChar - 'A' + 1).ToString());
                }
                else
                {
                    number = number * int.Parse((firstChar - 'a' + 1).ToString());
                }

                if (char.IsUpper(secondChar))
                {
                    number = number - int.Parse((secondChar - 'A' + 1).ToString());
                }
                else
                {
                    number = number + int.Parse((secondChar - 'a' + 1).ToString());
                }

                result += number;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
