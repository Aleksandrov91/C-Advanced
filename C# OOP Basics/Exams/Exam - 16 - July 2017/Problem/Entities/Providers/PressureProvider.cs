﻿public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        this.EnergyOutput = energyOutput + ((energyOutput / 100) * 50);
    }
}
