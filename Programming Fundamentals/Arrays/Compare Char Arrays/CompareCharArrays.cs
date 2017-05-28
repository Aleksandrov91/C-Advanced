using System;
using System.Linq;

namespace Compare_Char_Arrays
{
    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int minArr = Math.Min(firstArr.Length, secondArr.Length);
            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine(string.Join("", secondArr));
                Console.WriteLine(string.Join("", firstArr));
            }
            else if (secondArr.Length > firstArr.Length)
            {
                Console.WriteLine(string.Join("", firstArr));
                Console.WriteLine(string.Join("", secondArr));
            }
            else if (firstArr.Length == secondArr.Length)
            {
                for (int i = 0; i < minArr; i++)
                {
                    if (firstArr[i] > secondArr[i])
                    {
                        Console.WriteLine(string.Join("", secondArr));
                        Console.WriteLine(string.Join("", firstArr));
                        break;

                    }
                    else if (secondArr[i] >= firstArr[i])
                    {
                        Console.WriteLine(string.Join("", firstArr));
                        Console.WriteLine(string.Join("", secondArr));
                        break;
                    }
                }
            }
        }
    }
}
