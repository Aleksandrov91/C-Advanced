using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Balanced_Parenthesis
{
    public class BalancedParenthesis
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var openedParenthesis = new Stack<char>();
            var parenthesis = new char[] { '{', '[', '(' };
            var balanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                var currentElemet = input[i];

                if (parenthesis.Contains(currentElemet))
                {
                    openedParenthesis.Push(currentElemet);
                }
                else
                {
                    if (openedParenthesis.Count == 0)
                    {
                        balanced = false;
                        break;
                    }
                    else if (currentElemet == '}' && openedParenthesis.Pop() != '{')
                    {
                        balanced = false;
                        break;
                    }
                    else if (currentElemet == ']' && openedParenthesis.Pop() != '[')
                    {
                        balanced = false;
                        break;
                    }
                    else if (currentElemet == ')' && openedParenthesis.Pop() != '(')
                    {
                        balanced = false;
                        break;
                    }
                }
            }

            if (balanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
