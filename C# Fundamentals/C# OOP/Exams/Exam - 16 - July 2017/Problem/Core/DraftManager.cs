using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters;
    private List<Provider> providers;

    private double totalEnergy;
    private double totalMinedOre;
    private List<double> modeFactor;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.modeFactor = new List<double> { 1, 1 };
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var harvester = HarvesterFactory.CreateHarvester(arguments);
            this.harvesters.Add(harvester);

            return harvester.RegisterStatus();
        }
        catch (ArgumentException argumentException)
        {
            return argumentException.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var type = arguments[0];
            var id = arguments[1];
            var energyOutput = double.Parse(arguments[2]);

            var provider = ProviderFactory.CreateProvider(type, id, energyOutput);
            this.providers.Add(provider);

            return provider.RegisterStatus();
        }
        catch (ArgumentException argumentException)
        {
            return argumentException.Message;
        }
    }

    public string Day()
    {
        var sb = new StringBuilder();

        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {this.GetEnergy()}");
        sb.AppendLine($"Plumbus Ore Mined: {this.MineOre()}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        this.modeFactor.Clear();

        switch (arguments[0])
        {
            case "Full":
                this.modeFactor.Add(1.0);
                this.modeFactor.Add(1.0);
                break;
            case "Half":
                this.modeFactor.Add(0.6);
                this.modeFactor.Add(0.5);
                break;
            case "Energy":
                this.modeFactor.Add(0);
                this.modeFactor.Add(0);
                break;
        }

        return $"Successfully changed working mode to {arguments[0]} Mode";
    }

    public string Check(List<string> arguments)
    {
        if (this.harvesters.Any(h => h.Id == arguments[0]))
        {
            return this.harvesters.FirstOrDefault(h => h.Id == arguments[0]).ToString();
        }

        if (this.providers.Any(p => p.Id == arguments[0]))
        {
            return this.providers.FirstOrDefault(p => p.Id == arguments[0]).ToString();
        }

        return $"No element found with id - {arguments[0]}";
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();

        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

        return sb.ToString().Trim();
    }

    private double GetEnergy()
    {
        return this.providers.Sum(p => p.EnergyOutput);
    }

    private double NeededEnergy()
    {
        return this.harvesters.Sum(h => h.EnergyRequirement * this.modeFactor[0]);
        return this.harvesters.Sum(h => h.EnergyRequirement) * this.modeFactor[0];
    }

    private double MineOre()
    {
        var dayEnergy = this.GetEnergy();

        var neededEnergy = this.NeededEnergy();
        this.totalEnergy += dayEnergy;

        if (neededEnergy <= this.totalEnergy)
        {
            var minedOre = this.harvesters.Sum(h => h.OreOutput * this.modeFactor[1]);
            this.totalMinedOre += minedOre;
            this.totalEnergy -= neededEnergy;

            return minedOre;
        }

        return 0;
    }
}
