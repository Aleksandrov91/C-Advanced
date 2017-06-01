using System;
using System.Linq;

namespace _07.Lego_Blocks
{
    public class LegoBlocks
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int[][] firstJaggedArr = new int[n][];
            int[][] secondJaggedArr = new int[n][];

            for (int i = 0; i < 2 * n; i++)
            {
                if (i < n)
                {
                    firstJaggedArr[i] = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                }
                else
                {
                    secondJaggedArr[i - n] = Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                }
            }

            for (int row = 0; row < secondJaggedArr.Length; row++)
            {
                secondJaggedArr[row] = secondJaggedArr[row].Reverse().ToArray();
            }

            int[][] assembledMatrix = new int[n][];

            for (int row = 0; row < assembledMatrix.Length; row++)
            {
                assembledMatrix[row] = new int[firstJaggedArr[row].Length + secondJaggedArr[row].Length];

                for (int col = 0; col < firstJaggedArr[row].Length; col++)
                {
                    assembledMatrix[row][col] = firstJaggedArr[row][col];
                }

                for (int col = 0; col < secondJaggedArr[row].Length; col++)
                {
                    assembledMatrix[row][col + firstJaggedArr[row].Length] = secondJaggedArr[row][col];
                }
            }

            var isSquare = true;
            var cells = assembledMatrix[0].Length;

            for (int i = 1; i < assembledMatrix.Length; i++)
            {
                cells += assembledMatrix[i].Length;
                if (assembledMatrix[i].Length != assembledMatrix[i - 1].Length)
                {
                    isSquare = false;
                }
            }

            if (isSquare)
            {
                foreach (var element in assembledMatrix)
                {
                    Console.WriteLine($"[{string.Join(", ", element)}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {cells}");
            }
        }
    }
}
