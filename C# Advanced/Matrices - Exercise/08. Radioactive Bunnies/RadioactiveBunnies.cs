using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Radioactive_Bunnies
{
    public class RadioactiveBunnies
    {
        private static bool playerAlive;
        public static void Main()
        {
            playerAlive = true;
            var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var rows = elements[0];
            var cols = elements[1];

            char[][] bunniesLair = new char[rows][];

            var playerRowPosition = 0;
            var playerColPosition = 0;

            for (int row = 0; row < bunniesLair.Length; row++)
            {
                bunniesLair[row] = new char[cols];
                var line = Console.ReadLine();

                for (int col = 0; col < line.Length; col++)
                {
                    bunniesLair[row][col] = line[col];

                    if (bunniesLair[row][col] == 'P')
                    {
                        playerRowPosition = row;
                        playerColPosition = col;
                    }
                }
            }

            var playerCommands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < playerCommands.Length; i++)
            {

                switch (playerCommands[i])
                {
                    case 'U':
                        playerRowPosition = playerRowPosition - 1;

                        if (playerRowPosition < 0 || playerRowPosition >= bunniesLair.Length)
                        {
                            playerAlive = true;
                            bunniesLair[playerRowPosition][playerColPosition] = '.';
                            MultiplieBunnies(bunniesLair);
                            Print(bunniesLair);
                            return;
                        }

                        var newPlayerCoords = bunniesLair[playerRowPosition][playerColPosition];

                        if (newPlayerCoords == '.')
                        {
                            bunniesLair[playerRowPosition + 1][playerColPosition] = '.';
                            bunniesLair[playerRowPosition][playerColPosition] = 'P';
                        }
                        else
                        {
                            playerAlive = false;
                            Print(bunniesLair);
                            return;
                        }
                        break;
                    case 'D':
                        playerRowPosition = playerRowPosition + 1;

                        if (playerRowPosition < 0 || playerRowPosition >= bunniesLair.Length)
                        {
                            playerAlive = true;
                            bunniesLair[playerRowPosition][playerColPosition] = '.';
                            MultiplieBunnies(bunniesLair);
                            Print(bunniesLair);
                            return;
                        }

                        newPlayerCoords = bunniesLair[playerRowPosition][playerColPosition];

                        if (newPlayerCoords == '.')
                        {
                            bunniesLair[playerRowPosition - 1][playerColPosition] = '.';
                            bunniesLair[playerRowPosition][playerColPosition] = 'P';
                        }
                        else
                        {
                            playerAlive = false;
                            Print(bunniesLair);
                            return;
                        }
                        break;
                    case 'L':
                        playerColPosition = playerColPosition - 1;

                        if (playerColPosition < 0 || playerColPosition >= bunniesLair[0].Length)
                        {
                            playerAlive = true;
                            bunniesLair[playerRowPosition][playerColPosition + 1] = '.';
                            MultiplieBunnies(bunniesLair);
                            Print(bunniesLair);
                            return;
                        }

                        newPlayerCoords = bunniesLair[playerRowPosition][playerColPosition];

                        if (newPlayerCoords == '.')
                        {
                            bunniesLair[playerRowPosition][playerColPosition + 1] = '.';
                            bunniesLair[playerRowPosition][playerColPosition] = 'P';
                        }
                        else
                        {
                            playerAlive = false;
                            Print(bunniesLair);
                            return;
                        }
                        break;
                    case 'R':
                        playerColPosition = playerColPosition + 1;

                        if (playerColPosition < 0 || playerColPosition >= bunniesLair[0].Length)
                        {
                            playerAlive = true;
                            bunniesLair[playerRowPosition][playerColPosition] = '.';
                            MultiplieBunnies(bunniesLair);
                            Print(bunniesLair);
                            return;
                        }

                        newPlayerCoords = bunniesLair[playerRowPosition][playerColPosition];

                        if (newPlayerCoords == '.')
                        {
                            bunniesLair[playerRowPosition][playerColPosition - 1] = '.';
                            bunniesLair[playerRowPosition][playerColPosition] = 'P';
                        }
                        else
                        {
                            playerAlive = false;
                            Print(bunniesLair);
                            return;
                        }
                        break;
                }

                MultiplieBunnies(bunniesLair);

                if (!playerAlive)
                {
                    Print(bunniesLair);
                    return;
                }
            }

            Console.WriteLine($"{playerRowPosition} {playerColPosition}");
        }

        private static void MultiplieBunnies(char[][] bunniesLair)
        {
            List<KeyValuePair<int, int>> test = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < bunniesLair.Length; i++)
            {
                for (int j = 0; j < bunniesLair[i].Length; j++)
                {
                    if (bunniesLair[i][j] == 'B')
                    {
                        test.Add(new KeyValuePair<int, int>(i,j));
                    }
                }
            }

            for (int i = 0; i < test.Count; i++)
            {
                var row = test[i].Key;
                var col = test[i].Value;

                if (row < bunniesLair.Length - 1 && row > 0)
                {
                    PlayerDies(bunniesLair[row + 1][col]);
                    bunniesLair[row + 1][col] = 'B';
                }

                if (row > 0 && row < bunniesLair.Length - 1)
                {
                    PlayerDies(bunniesLair[row + 1][col]);
                    bunniesLair[row - 1][col] = 'B';
                }

                if (col < bunniesLair[row].Length - 1 && col > 0)
                {
                    PlayerDies(bunniesLair[row + 1][col]);
                    bunniesLair[row][col + 1] = 'B';
                }

                if (col > 0 && col < bunniesLair[row].Length - 1)
                {
                    PlayerDies(bunniesLair[row + 1][col]);
                    bunniesLair[row][col - 1] = 'B';
                }
            }
        }

        public static void PlayerDies(char check)
        {
            if (check == 'P')
            {
                check = 'B';
                playerAlive = false;
                return;
            }

            playerAlive = true;
        }

        public static void Print(char[][] bunniesLair)
        {
            foreach (var element in bunniesLair)
            {
                Console.WriteLine(string.Join("", element));
            }

            if (playerAlive)
            {
                Console.WriteLine($"won: 3 0");
            }
            else
            {
                Console.WriteLine($"dead: 3 1");
            }
        }
    }
}
