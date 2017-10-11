namespace _08.Military_Elite.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, double salary, string corps, List<IRepairable> parts)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = parts;
        }

        public List<IRepairable> Repairs { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            sb.Append("  " + string.Join(Environment.NewLine + "  ", this.Repairs));

            return sb.ToString().Trim();
        }
    }
}
