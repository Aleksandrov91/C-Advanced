namespace _05.Border_Control.Entities
{
    public class Citizen : IDweller
    {
        private string name;
        private int age;
        private string id;

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public string Id
        {
            get { return this.id; }
        }

        public override string ToString()
        {
            return this.Id;
        }
    }
}
