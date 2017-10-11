namespace _07.Food_Shortage.Entities
{
    public class Citizen : IDweller, IBirthdate, IBuyer, IPerson
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.FoodCount = 0;
        }

        public string Id { get; }

        public string Name { get; }

        public int Age { get; }

        public string Birthdate { get; }

        public int FoodCount { get; private set; }

        public void AddFood()
        {
            this.FoodCount += 10;
        }
    }
}
