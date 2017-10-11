namespace _11.Inferno_Infinity.Models.Gems
{
    using Enums;
    using Interfaces;

    public abstract class Gem : IGem
    {
        private GemQuality quality;

        public Gem(int strength, int agility, int vitality, string quality)
        {
            GemQuality.TryParse(quality, out this.quality);
            this.Strength = strength + (int)this.Quality;
            this.Agility = agility + (int)this.Quality;
            this.Vitality = vitality + (int)this.Quality;
        }

        public int Strength { get; }

        public int Agility { get; }

        public int Vitality { get; }

        public GemQuality Quality
        {
            get { return this.quality; }
        }
    }
}