public class RaceFactory
{
    public static Race OpenRace(string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                return new CasualRace(length, route, prizePool);
            case "Drag":
                return new DragRace(length, route, prizePool);
            case "Drift":
                return new DriftRace(length, route, prizePool);
            default:
                return null;
        }
    }

    public static Race OpenRace(string type, int length, string route, int prizePool, int specialParam)
    {
        switch (type)
        {
            case "Circuit":
                return new CircuitRace(length, route, prizePool, specialParam);
            case "TimeLimit":
                return new TimeLimitRace(length, route, prizePool, specialParam);
            default:
                return null;
        }
    }
}
