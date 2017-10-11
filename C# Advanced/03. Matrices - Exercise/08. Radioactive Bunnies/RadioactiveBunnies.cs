using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Radioactive_Bunnies
{
    public class RadioactiveBunnies
    {
        private static bool IsPlayerAlive;
        private static bool IsPlayerEscaped;
        private static int playerRowPosition;
        private static int playerColPosition;
        public static void Main()
        {
            IsPlayerAlive = true;
            IsPlayerEscaped = false;
            playerRowPosition = 0;
            playerColPosition = 0;

            var lairSize = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var buuniesLair = new char[lairSize[0]][];

            for (int row = 0; row < buuniesLair.Length; row++)
            {
                buuniesLair[row] = new char[lairSize[1]];
                var input = Console.ReadLine();
                for (int col = 0; col < buuniesLair[row].Length; col++)
                {
                    if (input[col] == 'P')
                    {
                        playerRowPosition = row;
                        playerColPosition = col;
                    }

                    buuniesLair[row][col] = input[col];
                }
            }

            var playerCommands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < playerCommands.Length; i++)
            {
                if (!IsPlayerAlive || IsPlayerEscaped)
                {
                    break;
                }

                PlayerMoves(buuniesLair, playerCommands[i]);

                MultiplieBunnies(buuniesLair);
            }

            PrintStatus(buuniesLair);
        }

        private static void PrintStatus(char[][] buuniesLair)
        {
            foreach (var row in buuniesLair)
            {
                Console.WriteLine(string.Join("", row));
            }

            if (IsPlayerEscaped)
            {
                Console.WriteLine($"won: {playerRowPosition} {playerColPosition}");
            }
            else
            {
                Console.WriteLine($"dead: {playerRowPosition} {playerColPosition}");
            }
        }

        private static void PlayerMoves(char[][] buuniesLair, char playerCommand)
        {
            buuniesLair[playerRowPosition][playerColPosition] = '.';
            var newPlayerRowPosition = playerRowPosition;
            var newPlayerColPosition = playerColPosition;

            switch (playerCommand)
            {
                case 'U':
                    newPlayerRowPosition--;
                    break;
                case 'D':
                    newPlayerRowPosition++;
                    break;
                case 'L':
                    newPlayerColPosition--;
                    break;
                case 'R':
                    newPlayerColPosition++;
                    break;
            }

            if (newPlayerRowPosition >= 0 && newPlayerColPosition >= 0 &&
                newPlayerRowPosition < buuniesLair.Length && newPlayerColPosition < buuniesLair[playerRowPosition].Length)
            {
                playerRowPosition = newPlayerRowPosition;
                playerColPosition = newPlayerColPosition;

                if (buuniesLair[playerRowPosition][playerColPosition] == 'B')
                {
                    IsPlayerAlive = false;
                }
                else
                {
                    buuniesLair[playerRowPosition][playerColPosition] = 'P';
                }
            }
            else
            {
                IsPlayerEscaped = true;
            }
        }

        private static void MultiplieBunnies(char[][] buuniesLair)
        {
            var bunniesPosition = new HashSet<KeyValuePair<int, int>>();

            for (int rowIndex = 0; rowIndex < buuniesLair.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < buuniesLair[rowIndex].Length; colIndex++)
                {
                    if (buuniesLair[rowIndex][colIndex] == 'B')
                    {
                        bunniesPosition.Add(new KeyValuePair<int, int>(rowIndex, colIndex));
                    }
                }
            }

            foreach (var keyValuePair in bunniesPosition)
            {
                for (int row = keyValuePair.Key - 1; row <= keyValuePair.Key + 1; row++)
                {
                    if (row >= 0 && row < buuniesLair.Length)
                    {
                        if (buuniesLair[row][keyValuePair.Value] == 'P')
                        {
                            IsPlayerAlive = false;
                        }

                        buuniesLair[row][keyValuePair.Value] = 'B';
                    }
                }

                for (int col = keyValuePair.Value - 1; col <= keyValuePair.Value + 1; col++)
                {
                    if (col >= 0 && col < buuniesLair[keyValuePair.Key].Length)
                    {
                        if (buuniesLair[keyValuePair.Key][col] == 'P')
                        {
                            IsPlayerAlive = false;
                        }

                        buuniesLair[keyValuePair.Key][col] = 'B';
                    }
                }
            }
        }
    }
}
