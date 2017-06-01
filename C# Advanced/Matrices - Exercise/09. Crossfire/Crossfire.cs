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

            var command = Console.ReadLine();

            while (command != "Nuke it from orbit")
            {
                var commandLine = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                long shootRow = commandLine[0];
                long shootCol = commandLine[1];
                long shootRadius = commandLine[2];

                if (shootRow < 0 || shootRow >= matrix.Length ||
                    shootCol < 0 || shootCol >= matrix[shootRow].Length)
                {
                    command = Console.ReadLine();
                    continue;
                }

                matrix[shootRow][shootCol] = null;

                for (long i = shootRow - shootRadius; i < shootRadius + shootRow; i++)
                {
                    if (i < 0 || i >= matrix.Length)
                    {
                        continue;
                    }

                    matrix[i][shootCol] = null;
                }

                for (long jIndex = shootCol - shootRadius; jIndex < shootCol + shootRadius; jIndex++)
                {
                    if (jIndex < 0 || jIndex >= matrix[0].Length)
                    {
                        continue;
                    }

                    matrix[shootRow][jIndex] = null;
                }

                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                    {
                        if (matrix[rowIndex][colIndex] == null)
                        {
                            for (int i = colIndex + 1; i < matrix[rowIndex].Length; i++)
                            {
                                if (matrix[rowIndex][i] != null)
                                {
                                    matrix[rowIndex][colIndex] = matrix[rowIndex][i];
                                    matrix[rowIndex][i] = null;
                                    colIndex++;
                                }
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == null)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(matrix[rowIndex][colIndex] + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
