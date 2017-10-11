namespace _08.Military_Elite.Entities
{
    using System;
    using System.Text;
    using Interfaces;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get
            {
                return this.corps;
            }

            protected set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException();
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");

            return sb.ToString().Trim();
        }
    }
}
