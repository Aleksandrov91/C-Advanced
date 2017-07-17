using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, List<Bender>> benders;
    private Dictionary<string, List<Monument>> monuments;
    private int warCount = 1;
    private StringBuilder war;

    public NationsBuilder()
    {
        this.benders = new Dictionary<string, List<Bender>>()
        {
            { "Fire", new List<Bender>() },
            { "Air", new List<Bender>() },
            { "Water", new List<Bender>() },
            { "Earth", new List<Bender>() }
        };
        this.monuments = new Dictionary<string, List<Monument>>()
        {
            { "Fire", new List<Monument>() },
            { "Air", new List<Monument>() },
            { "Water", new List<Monument>() },
            { "Earth", new List<Monument>() }
        };
        this.war = new StringBuilder();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var secondParam = double.Parse(benderArgs[3]);

        var bender = BenderFactory.CreateBender(type, name, power, secondParam);
        this.benders[type].Add(bender);
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);

        var monument = MonumentFactory.CreateMonument(type, name, affinity);
        this.monuments[type].Add(monument);
    }

    public string GetStatus(string nationsType)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");

        sb.Append("Benders: ");
        sb.AppendLine(this.benders[nationsType].Count == 0
            ? "None"
            : $"\r\n{string.Join(Environment.NewLine, this.benders[nationsType])}");

        sb.Append("Monuments: ");
        sb.AppendLine(this.monuments[nationsType].Count == 0
            ? "None"
            : $"\r\n{string.Join(Environment.NewLine, this.monuments[nationsType])}");

        return sb.ToString().Trim();
    }

    public void IssueWar(string nationsType)
    {
        var monumentBonus = new Dictionary<string, int>();

        foreach (var monument in this.monuments)
        {
            var bonus = monument.Value.Sum(m => m.MonumentBonus());
            monumentBonus.Add(monument.Key, bonus);
        }

        var totalPower = new Dictionary<string, double>();
        foreach (var bender in this.benders)
        {
            var benderPoints = bender.Value.Sum(b => b.GetWarPoints());
            var totalPoints = benderPoints + ((benderPoints / 100) * monumentBonus[bender.Key]);
            totalPower.Add(bender.Key, totalPoints);
        }

        var winner = totalPower.OrderByDescending(x => x.Value).FirstOrDefault();

        foreach (var bender in this.benders)
        {
            if (bender.Key != winner.Key)
            {
                bender.Value.Clear();
                this.monuments[bender.Key].Clear();
            }
        }

        this.war.AppendLine($"War {this.warCount++} issued by {nationsType}");
    }

    public string GetWarsRecord()
    {
        return this.war.ToString().Trim();
    }
}