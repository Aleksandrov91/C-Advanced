using System;

namespace Vowel_or_Digit
{
    public class VowelОrDigit
    {
        public static void Main()
        {
            char input = char.Parse(Console.ReadLine().ToLower());
            bool isVowel = "aeiou".IndexOf(input) >= 0;
            bool isDigit = "0123456789".IndexOf(input) >= 0;
            if (isDigit)
            {
                Console.WriteLine("digit");
            }
            else if (isVowel)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
