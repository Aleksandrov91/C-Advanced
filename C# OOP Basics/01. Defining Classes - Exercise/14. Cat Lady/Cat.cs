namespace _14.Cat_Lady
{
    public class Cat
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
