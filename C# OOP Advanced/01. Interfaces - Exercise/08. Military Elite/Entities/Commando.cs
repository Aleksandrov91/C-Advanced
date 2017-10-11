namespace _08.Military_Elite.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, double salary, string corps, List<IMission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public List<IMission> Missions { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            sb.Append("  " + string.Join(Environment.NewLine + "  ", this.Missions));

            return sb.ToString().Trim();
        }
    }
}
