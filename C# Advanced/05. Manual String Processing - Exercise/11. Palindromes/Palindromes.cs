namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;

    public class Palindromes
    {
        public static void Main()
        {
            var delimiters = new char[] { ' ', ',', '.', '?', '!' };
            var input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var result = new SortedSet<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentWord = input[i];
                if (IsPalindrome(currentWord))
                {
                    result.Add(currentWord);
                }
            }

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        private static bool IsPalindrome(string currentWord)
        {
            for (int i = 0; i < currentWord.Length / 2; i++)
            {
                if (currentWord[i] != currentWord[currentWord.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
