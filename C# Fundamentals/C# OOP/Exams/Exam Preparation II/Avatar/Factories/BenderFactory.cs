public class BenderFactory
{
    public static Bender CreateBender(string type, string name, int power, double secondParam)
    {
        switch (type)
        {
            case "Air":
                return new AirBender(name, power, secondParam);
            case "Fire":
                return new FireBender(name, power, secondParam);
            case "Water":
                return new WaterBender(name, power, secondParam);
            case "Earth":
                return new EarthBender(name, power, secondParam);
            default:
                return null;
        }
    }
}
