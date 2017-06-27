using System;
using System.Linq;

namespace _02.Monopoly
{
    public class Monopoly
    {
        public static int turns = 0;
        public static int totalHotels = 0;
        public static int playerMoney = 50;
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var gameField = new char[dimensions[0]][];

            for (int i = 0; i < dimensions[0]; i++)
            {
                gameField[i] = Console.ReadLine().ToCharArray();
            }

            for (int row = 0; row < gameField.Length; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < gameField[row].Length; col++)
                    {
                        playerMoney += totalHotels * 10;
                        PlayerMoves(gameField[row][col], row, col);
                        turns++;
                    }
                }
                else
                {
                    for (int col = gameField[row].Length - 1; col >= 0; col--)
                    {
                        playerMoney += totalHotels * 10;
                        PlayerMoves(gameField[row][col], row, col);
                        turns++;
                    }
                }
            }

            playerMoney += totalHotels * 10;

            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {playerMoney}");
        }

        private static void PlayerMoves(char currentPosition, int row, int col)
        {
            switch (currentPosition)
            {
                case 'H':
                    totalHotels++;
                    Console.WriteLine($"Bought a hotel for {playerMoney}. Total hotels: {totalHotels}.");
                    playerMoney = 0;
                    break;
                case 'J':
                    Console.WriteLine($"Gone to jail at turn {turns}.");
                    playerMoney += 2 * (totalHotels * 10);
                    turns += 2;
                    break;
                case 'S':
                    var moneyToSpend = (row + 1) * (col + 1);
                    if (playerMoney < moneyToSpend)
                    {
                        Console.WriteLine($"Spent {playerMoney} money at the shop.");
                        playerMoney = 0;
                    }
                    else
                    {
                        Console.WriteLine($"Spent {moneyToSpend} money at the shop.");
                        playerMoney -= moneyToSpend;
                    }
                    break;
            }

        }
    }
}
