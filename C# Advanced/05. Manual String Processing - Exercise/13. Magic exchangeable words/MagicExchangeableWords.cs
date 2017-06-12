namespace _13.Magic_exchangeable_words
{
    using System;
    using System.Collections.Generic;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);

            var keys = new Dictionary<char, char>();
            var firstWord = new Queue<char>(words[0].ToCharArray());
            var secondWord = new Queue<char>(words[1].ToCharArray());
            var isExchangeable = true;
            var firstWordChar = ' ';
            var secondWordChar = ' ';

            while (firstWord.Count > 0 || secondWord.Count > 0)
            {
                if (firstWord.Count > 0)
                {
                    firstWordChar = firstWord.Dequeue();
                }

                if (secondWord.Count > 0)
                {
                    secondWordChar = secondWord.Dequeue();
                }

                if (!keys.ContainsKey(firstWordChar))
                {
                    keys[firstWordChar] = secondWordChar;
                }
                else
                {
                    if (!keys.ContainsValue(secondWordChar))
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
