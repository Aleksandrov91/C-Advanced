public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput = oreOutput + ((oreOutput / 100) * 200);
        this.EnergyRequirement = energyRequirement + ((energyRequirement / 100) * 100);
    }
}
