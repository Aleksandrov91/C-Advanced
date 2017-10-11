namespace _14.Cat_Lady
{
    public class StreetExtraordinaire : Cat
    {
        private double decibeles;

        public StreetExtraordinaire(string name, double decibeles)
            : base(name)
        {
            this.decibeles = decibeles;
        }

        public override string ToString()
        {
            return $"StreetExtraordinaire {base.ToString()} {this.decibeles}";
        }
    }
}
