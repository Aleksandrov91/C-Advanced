using System.Collections.Generic;

public class HarvesterFactory
{
    public static Harvester CreateHarvester(List<string> haveresterArgs)
    {
        var type = haveresterArgs[0];
        haveresterArgs.Remove(type);

        var id = haveresterArgs[0];
        var oreOutput = double.Parse(haveresterArgs[1]);
        var energyRequirement = double.Parse(haveresterArgs[2]);

        switch (type)
        {
            case "Sonic":
                return new SonicHarvester(id, oreOutput, energyRequirement, int.Parse(haveresterArgs[3]));
            case "Hammer":
                return new HammerHarvester(id, oreOutput, energyRequirement);
            default:
                return null;
        }
    }
}