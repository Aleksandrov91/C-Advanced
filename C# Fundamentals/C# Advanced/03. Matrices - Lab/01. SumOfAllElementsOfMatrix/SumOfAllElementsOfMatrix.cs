using System;
using System.Linq;

namespace _01.SumOfAllElementsOfMatrix
{
    public class SumOfAllElementsOfMatrix
    {
        public static void Main()
        {
            var matrixElements = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var matrixRows = int.Parse(matrixElements[0]);
            var matrixCols = int.Parse(matrixElements[1]);

            var matrix = new int[matrixRows][];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                    matrix[rowIndex] = Console.ReadLine()
                        .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            }

            Console.WriteLine(matrixRows);
            Console.WriteLine(matrixCols);
            var matrixSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrixSum += matrix[i].Sum();
            }

            Console.WriteLine(matrixSum);
        }
    }
}
