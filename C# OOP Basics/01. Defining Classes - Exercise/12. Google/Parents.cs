namespace _12.Google
{
    public class Parents
    {
        private string name;
        private string birthday;

        public Parents(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Birthday
        {
            get { return this.birthday; }
        }
    }
}
