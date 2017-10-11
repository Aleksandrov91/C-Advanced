public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} get {this.salary:F2} leva";
    }

    public void IncreaseSalary(double bonus)
    {
        if (this.age > 30)
        {
            this.salary += this.salary * bonus / 100;
        }
        else
        {
            this.salary += this.salary * bonus / 200;
        }
    }
}
