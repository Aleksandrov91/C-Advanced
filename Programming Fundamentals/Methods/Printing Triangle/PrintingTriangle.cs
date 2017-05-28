using System;

namespace Printing_Triangle
{
    public class PrintingTriangle
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintLine(number);
        }

        public static void PrintLine(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintTriangle(row);
                Console.WriteLine();
            }

            for (int row = number - 1; row > 0; row--)
            {
                PrintTriangle(row);
                Console.WriteLine();
            }
        }

        public static void PrintTriangle(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
        }
    }
}
