namespace _05.Mordor_Cruelty_Plan.FoodModel
{
    public class Mushrooms : Food
    {
        private int pointsOfHappines = -10;

        public override int FoodFactor
        {
            get { return this.pointsOfHappines; }
        }
    }
}
