namespace _06.Birthday_Celebrations.Entities
{
    public class Citizen : IDweller, IBirthdate
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthdate = birthdate;
        }

        public string Id
        {
            get { return this.id; }
        }

        public string Birthdate
        {
            get { return this.birthdate; }
        }

        public override string ToString()
        {
            return this.Id;
        }
    }
}
