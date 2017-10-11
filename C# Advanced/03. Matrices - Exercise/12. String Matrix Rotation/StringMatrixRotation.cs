using System;
using System.Collections.Generic;

namespace _12.String_Matrix_Rotation
{
    public class StringMatrixRotation
    {
        public static void Main()
        {
            var command = Console.ReadLine();

            var rotateSplit = command.Substring(command.IndexOf("(") + 1,
                command.LastIndexOf(")") - command.IndexOf("(") - 1);
            var rotateDegrees = int.Parse(rotateSplit);
            var inputMatrix = new List<List<char>>();
            var maxCol = 0;
            var row = Console.ReadLine();

            while (row != "END")
            {
                inputMatrix.Add(new List<char>(row));

                if (row.Length > maxCol)
                {
                    maxCol = row.Length;
                }

                row = Console.ReadLine();
            }

            char[][] matrix = new char[inputMatrix.Count][];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = new char[maxCol];
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (colIndex >= inputMatrix[rowIndex].Count)
                    {
                        matrix[rowIndex][colIndex] = ' ';
                    }
                    else
                    {
                        matrix[rowIndex][colIndex] = inputMatrix[rowIndex][colIndex];
                    }
                }
            }

            for (int i = 0; i < (rotateDegrees / 90) % 4; i++)
            {
                matrix = RotateMatrix(matrix);
            }

            foreach (var element in matrix)
            {
                Console.WriteLine(string.Join("", element));
            }
        }

        private static char[][] RotateMatrix(char[][] matrix)
        {
            var tempMatrix = new char[matrix[0].Length][];

            for (int rowIndex = 0; rowIndex < tempMatrix.Length; rowIndex++)
            {
                tempMatrix[rowIndex] = new char[matrix.Length];

                for (int colIndex = 0; colIndex < tempMatrix[rowIndex].Length; colIndex++)
                {
                    tempMatrix[rowIndex][tempMatrix[rowIndex].Length - 1 - colIndex] = matrix[colIndex][rowIndex];
                }
            }

            return tempMatrix;
        }
    }
}
