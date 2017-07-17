namespace _11.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var trainers = new Dictionary<string, Trainer>();

            var inputLine = Console.ReadLine();

            while (inputLine != "Tournament")
            {
                var inputData = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var trainerName = inputData[0];
                var pokemonName = inputData[1];
                var pokemonElement = inputData[2];
                var pokemonHealth = int.Parse(inputData[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                
                if (!trainers.ContainsKey(trainerName))
                {
                    var trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);

                    trainers.Add(trainerName, trainer);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(pokemon);
                }

                inputLine = Console.ReadLine();
            }

            var element = Console.ReadLine();

            while (element != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.Value.CheckPokemonType(element);
                }

                element = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.Value.NumberOfBadges))
            {
                Console.WriteLine(trainer.Value.ToString());
            }
        }
    }
}
