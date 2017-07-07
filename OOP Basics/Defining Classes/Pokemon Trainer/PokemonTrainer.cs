namespace Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokemonTrainer
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();
            var input = Console.ReadLine();
            while (input!="Tournament")
            {
                var inputParams = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var pokemon = new Pokemon(inputParams[1],inputParams[2],int.Parse(inputParams[3]));

                if (trainers.Any(x => x.Name == inputParams[0]))
                {
                    var trainer = trainers.First(x => x.Name == inputParams[0]);
                    trainer.AddPokemon(pokemon);
                }
                else
                {
                    var trainer = new Trainer(inputParams[0]);
                    trainer.AddPokemon(pokemon);
                    trainers.Add(trainer);
                }

                input = Console.ReadLine();
            }

            var element = Console.ReadLine();
            while (element!="End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        var pokemonsToRemove  = new List<Pokemon>();
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                            if (pokemon.Health <= 0)
                            {
                                pokemonsToRemove.Add(pokemon);
                            }
                        }

                        foreach (var pokemon in pokemonsToRemove)
                        {
                            trainer.Pokemons.Remove(pokemon);
                        }
                    }
                }
                element = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
