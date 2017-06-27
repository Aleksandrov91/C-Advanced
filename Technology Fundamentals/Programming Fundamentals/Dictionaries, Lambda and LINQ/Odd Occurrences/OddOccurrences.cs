using System;
using System.Collections.Generic;
using System.Linq;
namespace Odd_Occurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower().Split(' ');

            var wordDict = new Dictionary<string, int>();

            foreach (var word in text)
            {
                if (!wordDict.ContainsKey(word))
                {
                    wordDict[word] = 0;
                }
                wordDict[word]++;
            }
            var result = new List<string>();
            foreach (var item in wordDict)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));


        }
    }
}
