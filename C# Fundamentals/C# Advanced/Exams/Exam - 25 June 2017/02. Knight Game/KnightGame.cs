using System;

namespace _02.Knight_Game
{
    public class KnightGame
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var removedKnights = 0;

            var matrix = new char[size][];

            for (var i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new char[size];
                var inputLine = Console.ReadLine();

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = inputLine[j];
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'K')
                    {
                        var needToRemove = ValidateKnight(matrix, row, col);
                        if (needToRemove)
                        {
                            matrix[row][col] = '0';
                            removedKnights++;
                        }
                    }
                }
            }

            Console.WriteLine(removedKnights);
        }

        private static bool ValidateKnight(char[][] chess, int startRow, int startCol)
        {
            if (chess[startRow - 2][startCol - 1] == 'K' &&
            chess[startRow - 2][startCol + 1] == 'K' &&
            chess[startRow + 2][startCol - 1] == 'K' &&
            chess[startRow + 2][startCol + 1] == 'K' &&
            chess[startRow - 1][startCol - 2] == 'K' &&
            chess[startRow + 1][startCol - 2] == 'K' &&
            chess[startRow - 1][startCol + 2] == 'K' &&
            chess[startRow + 1][startCol + 2] == 'K')
            {
                return true;
            }

            return false;
        }
    }
}
