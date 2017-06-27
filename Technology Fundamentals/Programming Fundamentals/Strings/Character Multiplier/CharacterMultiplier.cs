using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstString = input[0];
            var secondString = input[1];
            var result = 0;
            var maxString = Math.Max(firstString.Length, secondString.Length);

            for (int i = 0; i < maxString; i++)
            {
                var firstChar = 0;
                var secondChar = 0;

                if (i >= firstString.Length)
                {
                    secondChar = (int)secondString[i];
                    result += secondChar;
                }
                else if (i >= secondString.Length)
                {
                    firstChar = (int)firstString[i];
                    result += firstChar;
                }
                else
                {
                    firstChar = (int)firstString[i];
                    secondChar = (int)secondString[i];
                    var sumChars = firstChar * secondChar;
                    result += sumChars;
                }
            }

            Console.WriteLine(result);
        }
    }
}
