namespace _05.Mordor_Cruelty_Plan.FoodModel
{
    public class FoodFactory
    {
        public static Food CreateFood(string foodParam)
        {
            switch (foodParam.ToLower())
            {
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new Apple();
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new Other();
            }
        }
    }
}
