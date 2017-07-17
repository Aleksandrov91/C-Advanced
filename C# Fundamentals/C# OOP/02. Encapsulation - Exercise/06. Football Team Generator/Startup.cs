namespace _06.Football_Team_Generator
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var teams = new Dictionary<string, Team>();

            while (inputLine != "END")
            {
                var inputData = inputLine.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string teamName;
                string playerName;

                switch (inputData[0])
                {
                    case "Team":
                        try
                        {
                            if (!teams.ContainsKey(inputData[1]))
                            {
                                teams[inputData[1]] = new Team(inputData[1]);
                            }
                        }
                        catch (ArgumentException exception)
                        {
                            Console.WriteLine(exception.Message);
                            inputLine = Console.ReadLine();
                            continue;
                        }

                        break;

                    case "Add":
                        teamName = inputData[1];
                        playerName = inputData[2];
                        var endurance = int.Parse(inputData[3]);
                        var sprint = int.Parse(inputData[4]);
                        var dribble = int.Parse(inputData[5]);
                        var passing = int.Parse(inputData[6]);
                        var shooting = int.Parse(inputData[7]);

                        if (teams.ContainsKey(teamName))
                        {
                            try
                            {
                                var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                                teams[teamName].AddPlayer(player);
                            }
                            catch (ArgumentException exception)
                            {
                                Console.WriteLine(exception.Message);
                                inputLine = Console.ReadLine();
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }

                        break;

                    case "Remove":
                        teamName = inputData[1];
                        playerName = inputData[2];

                        if (teams.ContainsKey(teamName))
                        {
                            try
                            {
                                teams[teamName].RemovePlayer(playerName);
                            }
                            catch (ArgumentException exception)
                            {
                                Console.WriteLine(exception.Message);
                                inputLine = Console.ReadLine();
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }

                        break;

                    case "Rating":
                        teamName = inputData[1];
                        if (teams.ContainsKey(teamName))
                        {
                            var teamRating = teams[teamName].TeamRating();
                            Console.WriteLine($"{teamName} - {teamRating}");
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }

                        break;
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}