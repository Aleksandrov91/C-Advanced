namespace _08.Military_Elite.Entities
{
    using System.Text;
    using Interfaces;

    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Code Number: {this.CodeNumber}");

            return sb.ToString().Trim();
        }
    }
}
