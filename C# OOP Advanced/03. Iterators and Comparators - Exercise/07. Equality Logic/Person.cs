namespace _07.Equality_Logic
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }

        public int Age { get; }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var person = obj as Person;

            if (person == null)
            {
                return false;
            }

            return this.Name == person.Name && this.Age == person.Age;
        }
    }
}
