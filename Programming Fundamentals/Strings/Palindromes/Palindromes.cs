using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new HashSet<string>();
            for (int i = 0; i < text.Length; i++)
            {
                var currentWord = text[i];
                if (IsPalindrome(currentWord))
                {
                    result.Add(currentWord);
                }
            }

            string[] arrInt;
            // bind items to array from hashset object
            arrInt = result.ToArray();
            // Sort the array
            Array.Sort(arrInt);
            // Clear hashset object
            result.Clear();
            //Merge the array into hashset object with sort order
            result.UnionWith(arrInt);
            //Print the all items of the hashset object
            Console.WriteLine(string.Join(", ", result));
        }

        public static bool IsPalindrome(string currentWord)
        {
            for (int j = 0; j < currentWord.Length; j++)
            {
                var currentChar = currentWord[j];
                var lastChar = currentWord[currentWord.Length - 1 - j];
                if (currentChar != lastChar)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
