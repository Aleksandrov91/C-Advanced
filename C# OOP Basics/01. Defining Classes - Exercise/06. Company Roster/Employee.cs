namespace _06.Company_Roster
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string name, double salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.Email = "n/a";
            this.Age = -1;
        }

        public string Name
        {
            get { return this.name; }
        }

        public double Salary
        {
            get { return this.salary; }
        }

        public string Position
        {
            get { return this.position; }
        }

        public string Department
        {
            get { return this.department; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
