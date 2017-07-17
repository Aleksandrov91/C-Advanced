namespace _13.Family_Tree
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        private string firstName;
        private string lastName;
        private string birthday;
        private List<Person> parents;
        private List<Person> childrens;

        public Person(string firstName, string lastName, string birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.parents = new List<Person>();
            this.childrens = new List<Person>();
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public string Birthday
        {
            get { return this.birthday; }
        }

        public void AddChildren(Person children)
        {
            this.childrens.Add(children);
        }

        public void AddParent(Person parent)
        {
            this.parents.Add(parent);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.FirstName} {this.LastName} {this.Birthday}");
            sb.AppendLine("Parents:");
            if (this.parents.Count != 0)
            {
                sb.AppendLine(
                    $"{string.Join("\r\n", this.parents.Select(p => $"{p.FirstName} {p.LastName} {p.Birthday}"))}");
            }

            sb.AppendLine("Children:");
            if (this.childrens.Count != 0)
            {
                sb.AppendLine(
                    $"{string.Join("\r\n", this.childrens.Select(ch => $"{ch.FirstName} {ch.LastName} {ch.Birthday}"))}");
            }

            return sb.ToString();
        }
    }
}
