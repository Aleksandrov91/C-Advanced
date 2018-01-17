namespace _00.DatabaseModel.Data.Models
{
    using System.Collections.Generic;

    public class Town
    {
        public Town()
        {
        }

        public int TownId { get; set; }

        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
