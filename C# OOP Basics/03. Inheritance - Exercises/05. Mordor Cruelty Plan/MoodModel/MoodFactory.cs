namespace _05.Mordor_Cruelty_Plan.MoodModel
{
    public class MoodFactory
    {
        public static Mood CreateMood(int foodFactorPoints)
        {
            if (foodFactorPoints < -5)
            {
                return new Angry();
            }
            else if (foodFactorPoints <= 0)
            {
                return new Sad();
            }
            else if (foodFactorPoints <= 15)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}
