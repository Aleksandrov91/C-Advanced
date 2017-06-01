using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _06.Target_Practice
{
    public class TargetPractice
    {
        public static void Main()
        {
            var matrixElements = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            var snakeString = Console.ReadLine();
            var shoot = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            var shootRow = shoot[0];
            var shootCol = shoot[1];
            var shootRadius = shoot[2];

            char[][] staircase = new char[matrixElements[0]][];

            var i = 0;

            for (int row = staircase.Length - 1, move = 0; row >= 0; row--, move++)
            {
                staircase[row] = new char[matrixElements[1]];

                if (move % 2 == 0)
                {
                    for (int col = staircase[row].Length - 1; col >= 0; col--)
                    {
                        if (i == snakeString.Length)
                        {
                            i = 0;
                        }
                        staircase[row][col] = snakeString[i];
                        i++;
                    }
                }
                else
                {
                    for (int col = 0; col < staircase[row].Length; col++)
                    {
                        if (i == snakeString.Length)
                        {
                            i = 0;
                        }
                        staircase[row][col] = snakeString[i];
                        i++;
                    }
                }
            }

            staircase[shootRow][shootCol] = ' ';

            for (int rowIndex = 0; rowIndex < staircase.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < staircase[rowIndex].Length; colIndex++)
                {
                    //(x - center_x) ^ 2 + (y - center_y) ^ 2 <= radius ^ 2

                    var theorem = Math.Pow((rowIndex - shootRow), 2) + Math.Pow((colIndex - shootCol), 2);

                    if (theorem <= Math.Pow(shootRadius, 2))
                    {
                        staircase[rowIndex][colIndex] = ' ';
                    }
                }
            }

            for (int rowIndex = staircase.Length - 1; rowIndex >= 0; rowIndex--)
            {
                for (int colIndex = staircase[rowIndex].Length - 1; colIndex >= 0; colIndex--)
                {
                    var currentElement = staircase[rowIndex][colIndex];

                    if (currentElement == ' ')
                    {
                        var temp = rowIndex;
                        while (temp >= 0)
                        {
                            if (staircase[temp][colIndex] != ' ')
                            {
                                staircase[rowIndex][colIndex] = staircase[temp][colIndex];
                                staircase[temp][colIndex] = ' ';
                                break;
                            }

                            temp--;
                        }
                    }
                }
            }

            foreach (var element in staircase)
            {
                Console.WriteLine(string.Join("", element));
            }
        }
    }
}
