using System;
using System.Collections.Generic;

namespace Unicode_Characters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = "\\u" + ((int)input[i]).ToString("x4");
                result.Add(currentChar);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
