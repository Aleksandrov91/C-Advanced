using System;
using System.Collections.Generic;
using System.Linq;

namespace Football_League
{
    public class FootballLeague
    {
        public static void Main()
        {
            var decryptKey = Console.ReadLine();
            var result = new Dictionary<string, Football>();
            var input = Console.ReadLine();

            while (input != "final")
            {
                var splitNames = input.Split();
                var firstTeamName = GetTeamName(splitNames[0], decryptKey);
                var secondTeamName = GetTeamName(splitNames[1], decryptKey);
                var splitGoals = splitNames.Last().Split(':');
                var firstTeamGoals = int.Parse(splitGoals[0]);
                var secondTeamGoals = int.Parse(splitGoals[1]);
                GetTeamGoals(result, firstTeamName, firstTeamGoals);
                GetTeamGoals(result, secondTeamName, secondTeamGoals);
                GetWins(result, firstTeamName, firstTeamGoals, secondTeamName, secondTeamGoals);
                input = Console.ReadLine();
            }

            Console.WriteLine($"League standings:");
            var id = 1;
            foreach (var team in result.OrderByDescending(x => x.Value.Wins).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{id}. {team.Key} {team.Value.Wins}");
                id++;
            }

            Console.WriteLine($"Top 3 scored goals:");
            foreach (var team in result.OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");
            }
        }

        public static void GetWins(Dictionary<string, Football> result, string firstTeamName, int firstTeamGoals, string secondTeamName, int secondTeamGoals)
        {
            if (firstTeamGoals > secondTeamGoals)
            {
                result[firstTeamName].Wins += 3;
            }
            else if (firstTeamGoals == secondTeamGoals)
            {
                result[firstTeamName].Wins += 1;
                result[secondTeamName].Wins += 1;
            }
            else
            {
                result[secondTeamName].Wins += 3;
            }
        }

        public static void GetTeamGoals(Dictionary<string, Football> result, string teamName, int goals)
        {
            if (!result.ContainsKey(teamName))
            {
                result[teamName] = new Football();

            }

            result[teamName].Goals += goals;
        }

        public static string GetTeamName(string name, string decryptKey)
        {
            var start = name.IndexOf(decryptKey) + decryptKey.Length;
            var end = name.LastIndexOf(decryptKey);
            var lenght = end - start;
            var result = name.Substring(start, lenght);
            return string.Join(string.Empty, result.ToUpper().Reverse());
        }
    }

    public class Football
    {
        public int Wins { get; set; }

        public int Goals { get; set; }
    }
}
