using System;
using System.Linq;

namespace _03.Custom_Min_Function
{
    public class CustomMinFunction
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> minNumber = (x, y) => x < y;
            MinNumber(numbers, minNumber);
        }

        public static void MinNumber(int[] numbers, Func<int, int, bool> minNumber)
        {
            var minNum = int.MaxValue;
            foreach (var number in numbers)
            {
                if (minNumber(number, minNum))
                {
                    minNum = number;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
