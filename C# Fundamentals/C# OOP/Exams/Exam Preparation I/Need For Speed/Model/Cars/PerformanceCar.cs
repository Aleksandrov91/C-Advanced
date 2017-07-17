using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspention, int durability)
        : base(brand, model, yearOfProduction, horsePower, acceleration, suspention, durability)
    {
        this.HorsePower = this.HorsePower * 3 / 2;
        this.Suspension -= this.Suspension * 25 / 100;
        this.addOns = new List<string>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        if (this.addOns.Count == 0)
        {
            sb.AppendLine("Add-ons: None");
        }
        else
        {
            sb.AppendLine($"Add-ons: {string.Join(", ", this.addOns)}");
        }

        return sb.ToString().Trim();
    }

    public override void TuneCar(int tuneIndex, string addOn)
    {
        this.addOns.Add(addOn);
        base.TuneCar(tuneIndex, addOn);
    }
}
