namespace _05.Border_Control.Entities
{
    public class Robot : IDweller
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }

        public string Id
        {
            get { return this.id; }
        }

        public override string ToString()
        {
            return this.Id;
        }
    }
}
