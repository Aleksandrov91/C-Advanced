using System;
using System.Collections.Generic;
using System.Linq;

namespace Split_Word_Casing
{
    public class SplitWordCasing
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();
            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            foreach (var word in text)
            {
                bool isUpper = true;
                bool isLower = true;
                for (int symbol = 0; symbol < word.Length; symbol++)
                {
                    if (char.IsLower(word[symbol]))
                    {
                        isUpper = false;
                    }
                    else if (char.IsUpper(word[symbol]))
                    {
                        isLower = false;
                    }
                    else
                    {
                        isLower = false;
                        isUpper = false;
                    }
                }

                if (isUpper)
                {
                    upperCase.Add(word);
                }
                else if (isLower)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
