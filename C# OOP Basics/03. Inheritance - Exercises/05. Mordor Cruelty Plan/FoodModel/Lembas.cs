namespace _05.Mordor_Cruelty_Plan.FoodModel
{
    public class Lembas : Food
    {
        private int pointsOfHappines = 3;

        public override int FoodFactor
        {
            get { return this.pointsOfHappines; }
        }
    }
}
