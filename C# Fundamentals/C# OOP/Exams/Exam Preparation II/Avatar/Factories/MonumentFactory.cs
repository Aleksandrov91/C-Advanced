    public class MonumentFactory
    {
        public static Monument CreateMonument(string type, string name, int affinity)
        {
            switch (type)
            {
            case "Fire":
                return new FireMonument(name, affinity);
            case "Water":
                return new WaterMonument(name, affinity);
            case "Earth":
                return new EarthMonument(name, affinity);
            case "Air":
                return new AirMonument(name, affinity);
            default:
                return null;
            }
        }
    }
