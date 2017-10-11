namespace _03.Mankind
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private string facultyNumber;
        private Regex validateFacultyNumber = new Regex(@"^[a-zA-Z0-9]+$");

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            private set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                if (!this.validateFacultyNumber.IsMatch(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");

            return base.ToString() + sb.ToString();
        }
    }
}
