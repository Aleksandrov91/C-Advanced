namespace _02.Jedi_Galaxy
{
    using System;
    using System.Linq;

    public class JediGalaxy
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            var galaxy = new int[dimensions[0]][];
            var starPower = 0;
            for (int i = 0; i < galaxy.Length; i++)
            {
                galaxy[i] = new int[dimensions[1]];

                for (int j = 0; j < galaxy[i].Length; j++)
                {
                    galaxy[i][j] = starPower++;
                }
            }

            var positions = Console.ReadLine();
            var playerPosition = new int[2];
            var evilPower = new int[2];
            var playerScore = 0L;

            while (positions != "Let the Force be with you")
            {
                playerPosition = positions.Split(' ')
                    .Select(int.Parse).ToArray();
                evilPower = Console.ReadLine().Split(' ')
                    .Select(int.Parse).ToArray();

                galaxy = EvilTurn(evilPower, galaxy);
                playerScore += PlayerTurn(playerPosition, galaxy);

                positions = Console.ReadLine();
            }

            Console.WriteLine(playerScore);
        }

        private static long PlayerTurn(int[] playerPosition, int[][] galaxy)
        {
            var power = 0L;

            while (playerPosition[0] >= 0 && playerPosition[1] < galaxy[0].Length)
            {
                if (IsInGalaxy(playerPosition, galaxy))
                {
                    power += galaxy[playerPosition[0]][playerPosition[1]];
                }

                playerPosition[0]--;
                playerPosition[1]++;
            }

            return power;
        }

        private static int[][] EvilTurn(int[] evilPower, int[][] galaxy)
        {
            while (evilPower[0] >= 0 && evilPower[1] >= 0)
            {
                if (IsInGalaxy(evilPower, galaxy))
                {
                    galaxy[evilPower[0]][evilPower[1]] = 0;
                }

                evilPower[0]--;
                evilPower[1]--;
            }

            return galaxy;
        }

        private static bool IsInGalaxy(int[] playerPosition, int[][] galaxy)
        {
            return playerPosition[0] >= 0 && playerPosition[0] < galaxy.Length && playerPosition[1] >= 0 &&
                   playerPosition[1] < galaxy[playerPosition[0]].Length;
        }
    }
}
