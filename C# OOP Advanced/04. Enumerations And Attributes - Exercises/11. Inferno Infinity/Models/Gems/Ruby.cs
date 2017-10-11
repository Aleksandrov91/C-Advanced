namespace _11.Inferno_Infinity.Models.Gems
{
    using Interfaces;

    public class Ruby : Gem, IGem
    {
        private const int RubyStrength = 7;
        private const int RubyAgility = 2;
        private const int RubyVitality = 5;

        public Ruby(string quality)
            : base(RubyStrength, RubyAgility, RubyVitality, quality)
        {
        }
    }
}