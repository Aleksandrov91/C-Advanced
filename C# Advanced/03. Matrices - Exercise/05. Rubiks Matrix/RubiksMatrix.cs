using System;
using System.Linq;

namespace _05.Rubiks_Matrix
{
    public class RubiksMatrix
    {
        public static void Main()
        {
            var matrixElements = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());

            var rows = matrixElements[0];
            var cols = matrixElements[1];

            int[][] rubickMatrix = new int[rows][];
            var number = 1;

            for (int row = 0; row < rubickMatrix.Length; row++)
            {
                rubickMatrix[row] = new int[cols];

                for (int col = 0; col < rubickMatrix[row].Length; col++)
                {
                    rubickMatrix[row][col] = number;
                    number++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var position = int.Parse(line[0]);
                var command = line[1];
                var count = int.Parse(line[2]);

                if (command == "up")
                {
                    for (int j = 0; j < count % rubickMatrix[0].Length; j++)
                    {
                        var temp = rubickMatrix[0][position];
                        for (int k = 1; k < rubickMatrix.Length; k++)
                        {
                            rubickMatrix[k - 1][position] = rubickMatrix[k][position];
                        }

                        rubickMatrix[rubickMatrix.Length - 1][position] = temp;
                    }
                }
                else if (command == "down")
                {
                    for (int j = 0; j < count % rubickMatrix[0].Length; j++)
                    {
                        var temp = rubickMatrix[rubickMatrix.Length - 1][position];
                        for (int k = 1; k < rubickMatrix.Length; k++)
                        {
                            rubickMatrix[rubickMatrix.Length - k][position] = rubickMatrix[rubickMatrix.Length - k - 1][position];
                        }

                        rubickMatrix[0][position] = temp;
                    }
                }
                else if (command == "left")
                {
                    for (int j = 0; j < count % rubickMatrix.Length; j++)
                    {
                        var temp = rubickMatrix[position][0];
                        for (int k = 1; k < rubickMatrix[position].Length; k++)
                        {
                            rubickMatrix[position][k - 1] = rubickMatrix[position][k];
                        }

                        rubickMatrix[position][rubickMatrix.Length - 1] = temp;
                    }
                }
                else if (command == "right")
                {
                    for (int j = 0; j < count % rubickMatrix.Length; j++)
                    {
                        var temp = rubickMatrix[position][rubickMatrix.Length - 1];
                        for (int k = 1; k < rubickMatrix[position].Length; k++)
                        {
                            rubickMatrix[position][rubickMatrix.Length - k] = rubickMatrix[position][rubickMatrix.Length - k - 1];
                        }

                        rubickMatrix[position][0] = temp;
                    }
                }
            }

            number = 1;

            for (int row = 0; row < rubickMatrix.Length; row++)
            {
                for (int col = 0; col < rubickMatrix[row].Length; col++)
                {
                    if (rubickMatrix[row][col] == number)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int rowIndex = 0; rowIndex < rubickMatrix.Length; rowIndex++)
                        {
                            for (int colIndex = 0; colIndex < rubickMatrix[rowIndex].Length; colIndex++)
                            {
                                if (rubickMatrix[rowIndex][colIndex] == number)
                                {
                                    var temp = rubickMatrix[row][col];
                                    rubickMatrix[row][col] = rubickMatrix[rowIndex][colIndex];
                                    rubickMatrix[rowIndex][colIndex] = temp;
                                    Console.WriteLine($"Swap ({row}, {col}) with ({rowIndex}, {colIndex})");
                                    break;
                                }
                            }
                        }
                    }

                    number++;
                }
            }

        }
    }
}
