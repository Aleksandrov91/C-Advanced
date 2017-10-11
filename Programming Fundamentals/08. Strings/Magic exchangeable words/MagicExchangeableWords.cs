using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic_exchangeable_words
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var lowerString = input.OrderByDescending(x => x.Length).Last().ToString();
            var longerString = input.OrderByDescending(x => x.Length).First().ToString();
            var parsedChar = new Dictionary<char, char>();
            var isExchangeable = true;

            for (int i = 0; i < longerString.Length; i++)
            {
                var longStringChar = longerString[i];
                var lowStringChar = ' ';

                if (i < lowerString.Length)
                {
                    lowStringChar = lowerString[i];

                    if (!parsedChar.ContainsKey(longStringChar))
                    {
                        parsedChar[longStringChar] = lowStringChar;
                    }
                    else
                    {
                        if (parsedChar[longStringChar] != lowStringChar)
                        {
                            isExchangeable = false;
                            break;
                        }
                    }
                }
                else
                {
                    if (!parsedChar.ContainsKey(longStringChar))
                    {
                        isExchangeable = false;
                    }
                }
            }

            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
