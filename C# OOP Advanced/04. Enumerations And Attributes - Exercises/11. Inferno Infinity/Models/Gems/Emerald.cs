namespace _11.Inferno_Infinity.Models.Gems
{
    using Interfaces;

    public class Emerald : Gem, IGem
    {
        private const int EmeraldStrength = 1;
        private const int EmeraldAgility = 4;
        private const int EmeraldVitality = 9;

        public Emerald(string quality)
            : base(EmeraldStrength, EmeraldAgility, EmeraldVitality, quality)
        {
        }
    }
}