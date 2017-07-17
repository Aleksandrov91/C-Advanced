namespace _14.Cat_Lady
{
    public class Siamese : Cat
    {
        private double earSize;

        public Siamese(string name, double earSize)
            : base(name)
        {
            this.earSize = earSize;
        }

        public override string ToString()
        {
            return $"Siamese {base.ToString()} {this.earSize}";
        }
    }
}
