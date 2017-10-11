namespace _06.Strategy_Pattern
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }

        public int Age { get; }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
