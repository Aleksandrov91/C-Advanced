namespace _07.Food_Shortage.Entities
{
    public class Rebel : IDweller, IBuyer, IPerson
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.FoodCount = 0;
        }

        public string Id { get; }

        public string Name { get; }

        public int Age { get; }

        public string Group { get; }

        public int FoodCount { get; private set; }

        public void AddFood()
        {
            this.FoodCount += 5;
        }
    }
}
