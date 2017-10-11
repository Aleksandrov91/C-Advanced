namespace _03.Ferrari
{
    public class Ferrari : ICar
    {
        private string model;
        private string driver;

        public Ferrari(string driver)
        {
            this.driver = driver;
            this.model = "488-Spider";
        }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.model}/{this.Brakes()}/{this.Gas()}/{this.driver}";
        }
    }
}
