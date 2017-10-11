namespace _11.Pokemon_Trainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public string Element
        {
            get { return this.element; }
        }

        public bool TakeDamage()
        {
            this.health -= 10;

            if (this.health <= 0)
            {
                return true;
            }

            return false;
        }
    }
}
