namespace _14.Cat_Lady
{
    public class Cymric : Cat
    {
        private double furLenght;

        public Cymric(string name, double furLenght)
            : base(name)
        {
            this.furLenght = furLenght;
        }

        public override string ToString()
        {
            return $"Cymric {base.ToString()} {this.furLenght:F2}";
        }
    }
}
