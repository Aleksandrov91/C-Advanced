using System;

namespace _10.The_Heigan_Dance
{
    public class TheHeiganDance
    {
        private static int playerRowPosition;
        private static int playerColPosition;

        public static void Main()
        {
            var battlefield = InitializeMatrix();
            var playerDamage = decimal.Parse(Console.ReadLine());
            playerRowPosition = 7;
            playerColPosition = 7;
            decimal heiganHealth = 3000000;
            var playerHealth = 18500;
            var spell = string.Empty;
            var playerTakeDamage = false;

            while (true)
            {
                heiganHealth -= playerDamage;

                if (playerTakeDamage)
                {
                    playerHealth -= 3500;
                    playerTakeDamage = false;
                }

                if (heiganHealth <= 0 || playerHealth <= 0)
                {
                    GameOver(heiganHealth, playerHealth, playerRowPosition, playerColPosition, spell);
                    break;
                }

                var input = Console.ReadLine().Split(' ');
                spell = input[0];
                var shootRow = int.Parse(input[1]);
                var shootCol = int.Parse(input[2]);

                DamagedFields(battlefield, shootRow, shootCol);

                if (battlefield[playerRowPosition][playerColPosition] == "D")
                {
                    var isPlayerOnDamagedField = true;
                    for (int i = 1; i <= 4; i++)
                    {
                        if (PlayerMove(battlefield, i))
                        {
                            isPlayerOnDamagedField = false;
                            break;
                        }
                    }

                    if (isPlayerOnDamagedField)
                    {
                        if (spell == "Cloud")
                        {
                            playerHealth -= 3500;
                            playerTakeDamage = true;
                        }
                        else if (spell == "Eruption")
                        {
                            playerHealth -= 6000;
                        }
                    }

                    if (playerHealth <= 0)
                    {
                        GameOver(heiganHealth, playerHealth, playerRowPosition, playerColPosition, spell);
                        break;
                    }
                }

                battlefield = InitializeMatrix();
            }
        }

        private static void GameOver(decimal heiganHealth, int playerHealth, int playerRowPosition, int playerColPosition, string spell)
        {
            if (spell == "Cloud")
            {
                spell = "Plague Cloud";
            }

            Console.WriteLine(heiganHealth > 0 ? $"Heigan: {heiganHealth:F2}" : $"Heigan: Defeated!");
            Console.WriteLine(playerHealth > 0 ? $"Player: {playerHealth}" : $"Player: Killed by {spell}");
            Console.WriteLine($"Final position: {playerRowPosition}, {playerColPosition}");
        }

        private static void DamagedFields(string[][] battlefield, int shootRow, int shootCol)
        {
            for (int row = shootRow - 1; row <= shootRow + 1; row++)
            {
                for (int col = shootCol - 1; col <= shootCol + 1; col++)
                {
                    if (row >= 0 && col >= 0 && row < battlefield.Length && col < battlefield[row].Length)
                    {
                        battlefield[row][col] = "D";
                    }
                }
            }
        }

        private static bool PlayerMove(string[][] battlefield, int direction)
        {
            var newPlayerRowPosition = playerRowPosition;
            var newPlayerColPosition = playerColPosition;

            switch (direction)
            {
                case 1:
                    newPlayerRowPosition--;
                    break;
                case 2:
                    newPlayerColPosition++;
                    break;
                case 3:
                    newPlayerRowPosition++;
                    break;
                case 4:
                    newPlayerColPosition--;
                    break;
            }

            if (newPlayerRowPosition >= 0 && newPlayerRowPosition < battlefield.Length &&
                newPlayerColPosition >= 0 && newPlayerColPosition < battlefield[newPlayerRowPosition].Length &&
                battlefield[newPlayerRowPosition][newPlayerColPosition] != "D")
            {
                playerRowPosition = newPlayerRowPosition;
                playerColPosition = newPlayerColPosition;
                return true;
            }

            return false;
        }

        private static string[][] InitializeMatrix()
        {
            var battlefield = new string[15][];

            for (int row = 0; row < battlefield.Length; row++)
            {
                battlefield[row] = new string[15];

                for (int col = 0; col < battlefield[row].Length; col++)
                {
                    battlefield[row][col] = " ";
                }
            }

            return battlefield;
        }
    }
}