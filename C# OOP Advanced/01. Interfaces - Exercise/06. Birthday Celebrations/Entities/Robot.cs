namespace _06.Birthday_Celebrations.Entities
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
