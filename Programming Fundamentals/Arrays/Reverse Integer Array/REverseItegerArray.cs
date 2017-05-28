using System;

namespace Reverse_Integer_Array
{
    public class ReverseItegerArray
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var numberArr = new int[number];
            var reversedArr = new int[number];
            for (int i = 0; i < numberArr.Length; i++)
            {
                numberArr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numberArr.Length - 1; i >= 0; i--)
            {
                reversedArr[reversedArr.Length - i - 1] = numberArr[i];
            }
            Console.WriteLine(string.Join(" ", reversedArr));
        }
    }
}
