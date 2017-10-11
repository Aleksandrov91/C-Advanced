namespace _11.Inferno_Infinity.Models.Gems
{
    using Interfaces;

    public class Amethyst : Gem, IGem
    {
        private const int AmethystStrength = 2;
        private const int AmethystAgility = 8;
        private const int AmethystVitality = 4;

        public Amethyst(string quality)
            : base(AmethystStrength, AmethystAgility, AmethystVitality, quality)
        {
        }
    }
}