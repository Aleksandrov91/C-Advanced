namespace _14.Letters_Change_Numbers
{
    using System;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var totalSum = 0.0;

            foreach (var word in input)
            {
                totalSum += GetWordSum(word);
            }

            Console.WriteLine($"{totalSum:F2}");
        }

        private static double GetWordSum(string word)
        {
            var wordSum = 0.0;
            var digits = word.Substring(1, word.Length - 2);
            var number = double.Parse(digits);
            var firstChar = word[0];
            var lastChar = word[word.Length - 1];
            var temp = 0.0;

            if (char.IsLower(firstChar))
            {
                temp = number * (int)(firstChar - 'a' + 1);
            }
            else
            {
                temp = number / (int)(firstChar - 'A' + 1);
            }

            wordSum += temp;

            if (char.IsLower(lastChar))
            {
                wordSum = temp + (int)(lastChar - 'a' + 1);
            }
            else
            {
                wordSum = temp - (int)(lastChar - 'A' + 1);
            }

            return wordSum;
        }
    }
}
