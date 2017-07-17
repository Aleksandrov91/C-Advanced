using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester : MineWorker
{
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
        : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double EnergyRequirement
    {
        get
        {
            return this.energyRequirement;
        }

        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.EnergyRequirement)}");
            }

            this.energyRequirement = value;
        }
    }

    public double OreOutput
    {
        get
        {
            return this.oreOutput;
        }

        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.OreOutput)}");
            }

            this.oreOutput = value;
        }
    }

    public string RegisterStatus()
    {
        return $"Successfully registered {this.GetTypeName()} Harvester - {base.Id}".Trim();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.GetTypeName()} Harvester - {base.Id}");
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

        return sb.ToString().Trim();
    }

    private string GetTypeName()
    {
        var type = this.GetType().Name;
        return type.Replace("Harvester", string.Empty).Trim();
    }
}
