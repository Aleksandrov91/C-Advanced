using System;
using System.Linq;

public class Commands
{
    private NationsBuilder nation;

    public Commands()
    {
        this.nation = new NationsBuilder();
    }

    public void ReadCommands()
    {
        var command = Console.ReadLine();

        while (command != "Quit")
        {
            var tokens = command.Split(' ');
            this.ExecuteCommand(tokens);
            command = Console.ReadLine();
        }

        Console.WriteLine(this.nation.GetWarsRecord());
    }

    private void ExecuteCommand(string[] tokens)
    {
        switch (tokens[0])
        {
            case "Bender":
                var benderArgs = tokens.Skip(1).Take(4).ToList();
                this.nation.AssignBender(benderArgs);
                break;
            case "War":
                var nation = tokens[1];
                this.nation.IssueWar(nation);
                break;
            case "Monument":
                var monumentArgs = tokens.Skip(1).Take(3).ToList();
                this.nation.AssignMonument(monumentArgs);
                break;
            case "Status":
                var nationName = tokens[1];
                Console.WriteLine(this.nation.GetStatus(nationName));
                break;
        }
    }
}
