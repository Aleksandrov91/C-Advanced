using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public double GetTotalPower()
    {
        int monumentsIncreasePercentage = this.monuments.Sum(m => m.GetAffinity());
        double totalBendersPower = this.benders.Sum(b => b.GetPower());
        double totalPowerIncrease = (totalBendersPower / 100) * monumentsIncreasePercentage;
        return totalBendersPower + totalPowerIncrease;
    }

    public void AddBender(Bender bender) => this.benders.Add(bender);

    public void AddMonument(Monument monument) => this.monuments.Add(monument);

    public override string ToString()
    {
        var result = new StringBuilder();
        result.Append("Benders:");
        if (this.benders.Any())
        {
            result.AppendLine("\r\n" + string.Join(Environment.NewLine, this.benders.Select(b => $"###{b}")).Trim());
        }
        else
        {
            result.AppendLine(" None");
        }

        result.Append("Monuments:");
        if (this.monuments.Any())
        {
            result.AppendLine("\r\n" + string.Join(Environment.NewLine, this.monuments.Select(m => $"###{m}")).Trim());
        }
        else
        {
            result.AppendLine(" None");
        }

        return result.ToString().Trim();
    }

    public void DeclarateDefeat()
    {
        this.benders.Clear();
        this.monuments.Clear();
    }
}
