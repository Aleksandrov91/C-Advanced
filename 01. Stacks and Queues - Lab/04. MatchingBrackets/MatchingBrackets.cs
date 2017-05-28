using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    public class MatchingBrackets
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var character = input[i];

                if (character.Equals('('))
                {
                    stack.Push(i);
                }
                else if (character.Equals(')'))
                {
                    var startIndex = stack.Pop();

                    var bracet = input.Substring(startIndex, i - startIndex + 1);

                    Console.WriteLine(bracet);
                }
            }
        }
    }
}
