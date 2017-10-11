namespace _11.Inferno_Infinity.Interfaces
{
    using System;
    using Enums;

    public interface IGem
    {
        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }

        GemQuality Quality { get; }
    }
}