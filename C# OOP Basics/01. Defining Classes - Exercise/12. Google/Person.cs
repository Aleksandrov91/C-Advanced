namespace _12.Google
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Parents> parents;
        private List<Children> childrens;
        private List<Pokemon> pokemons;

        public Person(string name)
        {
            this.name = name;
            this.company = new Company();
            this.car = new Car();
            this.parents = new List<Parents>();
            this.childrens = new List<Children>();
            this.pokemons = new List<Pokemon>();
        }

        public Company Company
        {
            get { return this.company; }
            set { this.company = value; }
        }

        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        public List<Parents> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public List<Children> Childrens
        {
            get { return this.childrens; }
            set { this.childrens = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.name);
            sb.AppendLine("Company:");
            if (this.company.Name != null)
            {
                sb.AppendLine($"{this.company.Name} {this.company.Department} {this.company.Salary:F2}");
            }

            sb.AppendLine("Car:");
            if (this.car.Model != null)
            {
                sb.AppendLine($"{this.car.Model} {car.Speed}");
            }

            sb.AppendLine("Pokemon:");
            if (this.pokemons.Count != 0)
            {
                sb.AppendLine($"{string.Join("\r\n", this.pokemons.Select(p => $"{p.Name} {p.Type}"))}");
            }

            sb.AppendLine("Parents:");
            if (this.parents.Count != 0)
            {
                sb.AppendLine($"{string.Join("\r\n", this.parents.Select(p => $"{p.Name} {p.Birthday}"))}");
            }

            sb.AppendLine("Children:");
            if (this.childrens.Count != 0)
            {
                sb.AppendLine($"{string.Join("\r\n", this.childrens.Select(c => $"{c.Name} {c.Birthday}"))}");
            }

            return sb.ToString();
        }
    }
}
