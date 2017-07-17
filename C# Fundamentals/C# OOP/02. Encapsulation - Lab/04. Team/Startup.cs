using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var team = new Team("asd");
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            Person person;

            try
            {
                person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), double.Parse(cmdArgs[3]));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                continue;
            }

            team.AddPlayer(person);
        }

        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reverse team have {team.ReserveTeam.Count} palyers");
    }
}
