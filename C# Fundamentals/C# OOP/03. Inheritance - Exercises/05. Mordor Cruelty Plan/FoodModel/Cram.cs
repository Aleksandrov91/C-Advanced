namespace _05.Mordor_Cruelty_Plan.FoodModel
{
    public class Cram : Food
    {
        private int pointsOfHappines = 2;

        public override int FoodFactor
        {
            get { return this.pointsOfHappines; }
        }
    }
}
