namespace _03.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(weekSalary)}");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(workHoursPerDay)}");
                }

                this.workHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Week Salary: {this.weekSalary:F2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}");
            sb.AppendLine($"Salary per hour: {this.MoneyEarnsByHour():F2}");

            return base.ToString() + sb.ToString();
        }

        private double MoneyEarnsByHour()
        {
            var workingDays = 5;
            var salaryPerDay = this.WeekSalary / workingDays;
            var salaryPerHour = salaryPerDay / this.WorkHoursPerDay;
            return salaryPerHour;
        }
    }
}
