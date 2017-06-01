using System;
using System.Linq;

namespace _02.Diagonal_Difference
{
    public class DiagonalDifference
    {
        public static void Main()
        {
            var matrixLength = int.Parse(Console.ReadLine());

            int[][] matrix = new int[matrixLength][];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            int leftDiagonalSum = 0;
            int rightDiagonalSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                leftDiagonalSum += matrix[i][i];
                rightDiagonalSum += matrix[i][matrixLength - i - 1];
            }

            Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
        }
    }
}
