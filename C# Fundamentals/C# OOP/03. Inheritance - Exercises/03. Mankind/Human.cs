namespace _03.Mankind
{
    using System;
    using System.Text;

    public class Human
    {
        private const int MinFirstNameLenght = 4;
        private const int MinLastNameLenght = 3;
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                this.ValidateNames(value, MinLastNameLenght, nameof(this.lastName));
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                this.ValidateNames(value, MinFirstNameLenght, nameof(this.firstName));
                this.firstName = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");

            return sb.ToString();
        }

        private void ValidateNames(string name, int lenght, string propertyName)
        {
            if (!char.IsUpper(name[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {propertyName}");
            }

            if (name.Length < lenght)
            {
                throw new ArgumentException($"Expected length at least {lenght} symbols! Argument: {propertyName}");
            }
        }
    }
}
