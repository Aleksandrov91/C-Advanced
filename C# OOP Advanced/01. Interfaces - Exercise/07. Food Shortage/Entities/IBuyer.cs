namespace _07.Food_Shortage.Entities
{
    public interface IBuyer : IPerson
    {
        int FoodCount { get; }

        void AddFood();
    }
}
