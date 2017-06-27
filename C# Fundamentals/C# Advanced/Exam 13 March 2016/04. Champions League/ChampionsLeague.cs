using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Champions_League
{
    public class ChampionsLeague
    {
        public static void Main()
        {
            var rgx = new Regex(@"([A-Z a-z]+)\|([A-Z a-z]+)\|\s+(\d:\d)\s+\|\s+(\d:\d)");
            var inputLine = Console.ReadLine();
            var wins = new Dictionary<string, int>();
            var oponents = new Dictionary<string, SortedSet<string>>();

            while (inputLine != "stop")
            {
                var match = rgx.Match(inputLine);

                if (!match.Success)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                var firstTeam = match.Groups[1].Value.Trim();
                var secondTeam = match.Groups[2].Value.Trim();
                var firstMatchScore = match.Groups[3].Value;
                var secondMatchScore = match.Groups[4].Value;
                var firstTeamWinner = GetWinner(firstTeam, secondTeam, firstMatchScore, secondMatchScore);
                if (firstTeamWinner)
                {
                    AddWinner(wins, firstTeam);
                    AddLooser(wins, secondTeam);
                }
                else
                {
                    AddWinner(wins, secondTeam);
                    AddLooser(wins, firstTeam);
                }
                AddOpponent(oponents, firstTeam, secondTeam);
                AddOpponent(oponents, secondTeam, firstTeam);

                inputLine = Console.ReadLine();
            }

            foreach (var team in wins.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine($"- Wins: {team.Value}");
                Console.WriteLine($"- Opponents: {string.Join(", ", oponents[team.Key])}");
            }
        }

        private static void AddLooser(Dictionary<string, int> wins, string secondTeam)
        {
            if (!wins.ContainsKey(secondTeam))
            {
                wins[secondTeam] = 0;
            }
        }

        private static void AddWinner(Dictionary<string, int> wins, string firstTeam)
        {
            if (!wins.ContainsKey(firstTeam))
            {
                wins[firstTeam] = 0;
            }

            wins[firstTeam]++;
        }

        private static void AddOpponent(Dictionary<string, SortedSet<string>> oponents, string firstTeam, string secondTeam)
        {
            if (!oponents.ContainsKey(firstTeam))
            {
                oponents[firstTeam] = new SortedSet<string>();
            }

            oponents[firstTeam].Add(secondTeam);
        }

        private static bool GetWinner(string firstTeam, string secondTeam, string firstMatchScore, string secondMatchScore)
        {
            var firstMatch = GetGoals(firstMatchScore);
            var secondMatch = GetGoals(secondMatchScore);

            if (firstMatch[0] + secondMatch[1] > firstMatch[1] + secondMatch[0])
            {
                return true;
            }
            else if (firstMatch[0] + secondMatch[1] == firstMatch[1] + secondMatch[0])
            {
                if (secondMatch[1] > firstMatch[1])
                {
                    return true;
                }
            }

            return false;


        }

        private static int[] GetGoals(string firstMatchScore)
        {
            return firstMatchScore.Split(':').Select(int.Parse).ToArray();
        }
    }
}
