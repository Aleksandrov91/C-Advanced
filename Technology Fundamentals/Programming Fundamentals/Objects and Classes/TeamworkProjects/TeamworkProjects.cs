using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    public class TeamworkProjects
    {
        public static void Main()
        {
            var numberOfTeams = int.Parse(Console.ReadLine());
            var teamsData = new SortedDictionary<string, Team>();
            for (int i = 0; i < numberOfTeams; i++)
            {
                var input = Console.ReadLine().Split('-');
                var teamName = input[1];
                var creatorName = input[0];
                var currentTeam = new Team
                {
                    Creators = new List<string>(),
                    Users = new List<string>()
                };
                if (!teamsData.ContainsKey(teamName) && !teamsData.Any(x => x.Value.Creators.Contains(creatorName)))
                {
                    teamsData[teamName] = currentTeam;
                    teamsData[teamName].Creators.Add(creatorName);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (teamsData.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
            }

            var userRequest = Console.ReadLine();
            while (userRequest != "end of assignment")
            {
                var line = userRequest.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                var user = line[0];
                var team = line[1];
                if (!teamsData.ContainsKey(team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teamsData.Any(c => c.Value.Creators.Contains(user)) || teamsData.Any(c => c.Value.Users.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                }
                else
                {
                    teamsData[team].Users.Add(user);
                }

                userRequest = Console.ReadLine();
            }

            var disbandTeam = new List<string>();
            foreach (var team in teamsData.OrderByDescending(x => x.Value.Users.Count))
            {
                if (team.Value.Users.Count != 0)
                {
                    Console.WriteLine($"{team.Key}");
                    var teamCreator = team.Value.Creators;
                    var teamUsers = team.Value.Users.OrderBy(x => x);
                    foreach (var creator in teamCreator)
                    {
                        Console.WriteLine($"- {creator}");
                    }

                    foreach (var user in teamUsers)
                    {
                        Console.WriteLine($"-- {user}");
                    }
                }
                else
                {
                    disbandTeam.Add(team.Key);
                }
            }

            Console.WriteLine("Teams to disband:");
            Console.WriteLine(string.Join("\r\n", disbandTeam.OrderBy(x => x)));
        }
    }
}
