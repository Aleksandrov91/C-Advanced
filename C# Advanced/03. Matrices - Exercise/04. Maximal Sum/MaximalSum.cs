using System;
using System.Linq;

namespace _04.Maximal_Sum
{
    public class MaximalSum
    {
        public static void Main()
        {
            var matrixLength = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[][] matrix = new int[matrixLength[0]][];

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                matrix[rows] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSum = int.MinValue;
            int[][] tempMatrix = new int[3][];
            int[][] maxSumMatric = new int[3][];

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    var tempSum = 0;

                    for (int i = 0; i < tempMatrix.Length; i++)
                    {
                        tempMatrix[i] = new int[3];

                        for (int j = 0; j < tempMatrix[i].Length; j++)
                        {
                            tempMatrix[i][j] = matrix[row + i][col + j];
                            tempSum += tempMatrix[i][j];
                        }
                    }

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;

                        for (int i = 0; i < maxSumMatric.Length; i++)
                        {
                            maxSumMatric[i] = tempMatrix[i];
                        }
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            foreach (var element in maxSumMatric)
            {
                Console.WriteLine(string.Join(" ", element));
            }
        }
    }
}
