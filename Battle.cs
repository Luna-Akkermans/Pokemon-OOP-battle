using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokemon_OOP_battle
{
    public class Battle
    {
        public void PerformBattle(Trainer firstTrainer, Trainer secondTrainer)
        {
            for (int pokeballIndex = 0; pokeballIndex < firstTrainer.Belt.Count; pokeballIndex++)
            {
                Console.WriteLine(firstTrainer.Name);

                Console.WriteLine("Opens");
                firstTrainer.ThrowPokeball(pokeballIndex);
                firstTrainer.Belt[pokeballIndex].pokemon.WarCry();

                Console.WriteLine("Closes");
                firstTrainer.ReturnPokemon(pokeballIndex);

                // Switch to the second trainer
                Console.WriteLine(secondTrainer.Name);

                Console.WriteLine("Opens");
                secondTrainer.ThrowPokeball(pokeballIndex);
                secondTrainer.Belt[pokeballIndex].pokemon.WarCry();

                Console.WriteLine("Closes");
                secondTrainer.ReturnPokemon(pokeballIndex);
            }
        }
    }
}
