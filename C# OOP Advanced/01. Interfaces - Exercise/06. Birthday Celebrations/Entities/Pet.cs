namespace _06.Birthday_Celebrations.Entities
{
    public class Pet : IBirthdate
    {
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            this.birthdate = birthdate;
        }

        public string Birthdate
        {
            get { return this.birthdate; }
        }
    }
}
