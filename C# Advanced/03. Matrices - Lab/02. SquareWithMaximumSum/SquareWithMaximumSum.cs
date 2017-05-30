using System;
using System.Linq;

namespace _02.SquareWithMaximumSum
{
    public class SquareWithMaximumSum
    {
        public static void Main()
        {
            var matrixElements = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrixRows = matrixElements[0];
            var matrixCols = matrixElements[1];

            var matrix = new int[matrixRows][];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSquareRow = 0;
            var maxSquareCol = 0;
            var maxSum = int.MinValue;

            for (int rowIndex = 0; rowIndex < matrix.Length - 1; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length - 1; colIndex++)
                {
                    var currentSum = matrix[rowIndex][colIndex] + matrix[rowIndex][colIndex + 1] +
                                     matrix[rowIndex + 1][colIndex] + matrix[rowIndex + 1][colIndex + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSquareRow = rowIndex;
                        maxSquareCol = colIndex;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol + 1]}");
            Console.WriteLine($"{matrix[maxSquareRow + 1][maxSquareCol]} {matrix[maxSquareRow + 1][maxSquareCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
