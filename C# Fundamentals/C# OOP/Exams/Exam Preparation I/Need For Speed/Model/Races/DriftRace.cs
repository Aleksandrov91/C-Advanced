public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {
    }

    protected override int GetPoints(Car car)
    {
        return car.Suspension + car.Durability;
    }
}
