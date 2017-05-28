using System;
using System.Collections.Generic;

namespace _03.DecimalToBinaryConverter
{
    public class DecimalToBinaryConverter
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            if (input.Equals(0))
            {
                Console.WriteLine("0");
            }

            var binary = new Stack<int>();

            while (input > 0)
            {
                binary.Push(input % 2);

                input = input / 2;
            }

            while (binary.Count > 0)
            {
                Console.Write(binary.Pop());
            }

            Console.WriteLine();
        }
    }
}
