namespace _08.Military_Elite.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<ISoldier> soldier)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = soldier;
        }

        public List<ISoldier> Privates { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            sb.Append($"  {string.Join(Environment.NewLine + "  ", this.Privates)}");

            return sb.ToString().Trim();
        }
    }
}
