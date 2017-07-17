public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {
    }

    protected override int GetPoints(Car car)
    {
        return car.HorsePower / car.Acceleration;
    }
}
