using System;
using System.Linq;

namespace _03.Squares_in_Matrix
{
    public class SquaresInMatrix
    {
        public static void Main()
        {
            var matrixLength = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            var rows = matrixLength[0];
            var cols = matrixLength[1];

            string[][] matrix = new string[rows][];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            var submatrix = 0;

            for (int rowIndex = 0; rowIndex < matrix.Length - 1; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length - 1; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == matrix[rowIndex + 1][colIndex] &&
                        matrix[rowIndex][colIndex + 1] == matrix[rowIndex + 1][colIndex + 1] &&
                        matrix[rowIndex][colIndex] == matrix[rowIndex][colIndex + 1] &&
                        matrix[rowIndex + 1][colIndex] == matrix[rowIndex + 1][colIndex + 1])
                    {
                        submatrix++;
                    }
                }
            }

            Console.WriteLine(submatrix);
        }
    }
}
