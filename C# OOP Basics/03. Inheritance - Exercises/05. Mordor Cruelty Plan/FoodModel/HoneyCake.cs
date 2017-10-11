namespace _05.Mordor_Cruelty_Plan.FoodModel
{
    public class HoneyCake : Food
    {
        private int pointsOfHappines = 5;

        public override int FoodFactor
        {
            get { return this.pointsOfHappines; }
        }
    }
}
