using System;
using System.Linq;

namespace _09.Crossfire
{
    public class Crossfire
    {
        public static void Main()
        {
            var matrixElements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrixRows = matrixElements[0];
            var matrixCols = matrixElements[1];

            string[][] matrix = new string[matrixRows][];

            InitializeMatrix(matrix, matrixCols);

            var command = Console.ReadLine();

            while (command != "Nuke it from orbit")
            {
                var commandLine = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int shootRow = commandLine[0];
                int shootCol = commandLine[1];
                int shootRadius = commandLine[2];

                RemoveRows(matrix, shootRow, shootCol, shootRadius);
                RemoveCols(matrix, shootRow, shootCol, shootRadius);

                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                    {
                        if (matrix[rowIndex][colIndex] == null)
                        {
                            matrix[rowIndex] = matrix[rowIndex].Where(n => n != null).ToArray();
                        }
                    }

                    if (matrix[rowIndex].Length < 1)
                    {
                        matrix = matrix.Take(rowIndex).Concat(matrix.Skip(rowIndex + 1)).ToArray();
                        rowIndex--;
                    }
                }

                command = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void InitializeMatrix(string[][] matrix, int matrixCols)
        {
            int number = 1;

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = new string[matrixCols];

                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    matrix[rowIndex][colIndex] = number.ToString();
                    number++;
                }
            }
        }

        private static void RemoveCols(string[][] matrix, int shootRow, int shootCol, int shootRadius)
        {
            for (int col = shootCol - shootRadius; col <= shootCol + shootRadius; col++)
            {
                if (shootRow >= 0 && col >= 0 && shootRow < matrix.Length && col < matrix[shootRow].Length)
                {
                    matrix[shootRow][col] = null;
                }
            }
        }

        private static void RemoveRows(string[][] matrix, int shootRow, int shootCol, int shootRadius)
        {
            for (int row = shootRow - shootRadius; row <= shootRadius + shootRow; row++)
            {
                if (row >= 0 && shootCol >= 0 && row < matrix.Length && shootCol < matrix[row].Length)
                {
                    matrix[row][shootCol] = null;
                }
            }
        }

        private static void PrintMatrix(string[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
