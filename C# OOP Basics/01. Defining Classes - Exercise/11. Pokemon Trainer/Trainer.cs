namespace _11.Pokemon_Trainer
{
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.name = name;
            this.numberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public int NumberOfBadges
        {
            get { return this.numberOfBadges; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public void CheckPokemonType(string type)
        {
            if (this.Pokemons.Any(p => p.Element == type))
            {
                this.numberOfBadges++;
            }
            else
            {
                this.PokemonsTakeDamage();
            }
        }

        public override string ToString()
        {
            return $"{this.name} {this.NumberOfBadges} {this.Pokemons.Count}";
        }

        private void PokemonsTakeDamage()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                var isDied = this.Pokemons[i].TakeDamage();

                if (isDied)
                {
                    this.Pokemons.Remove(this.Pokemons[i]);
                }
            }
        }
    }
}
