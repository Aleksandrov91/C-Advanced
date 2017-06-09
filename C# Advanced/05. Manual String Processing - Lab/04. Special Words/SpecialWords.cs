using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Special_Words
{
    public class SpecialWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var wordsCount = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                wordsCount[words[i]] = 0;
            }
            var text = Console.ReadLine().Split(new []{'(', ')', '[', ']', '<', '>', ',', '-', '!', '?',' '},StringSplitOptions.RemoveEmptyEntries);
            //( ) [ ] < > , - ! ? and space (‘ ’) 
            foreach (var word in text)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            foreach (var word in wordsCount)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }

        }
    }
}
