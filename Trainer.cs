using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_OOP_battle
{
    public class Trainer
    {
        public string Name { get; set; }
        public List<Pokeball> Belt { get; set; }

        public Trainer(string name, List<Pokeball> belt)
        {
            Name = name;
            Belt = belt;
        }

        public void ThrowPokeball(int number)
        {
            Console.WriteLine($"{Name} has thrown a pokeball!");
            Belt[number].Open();
        }

        public void KillPokemon(Pokemon pokemon)
        {
            foreach (Pokeball pokeball in Belt.ToList())
            {
                if (pokeball.pokemon == pokemon)
                {
                    Belt.Remove(pokeball);
                    Console.WriteLine($"{Name}'s pokemon {pokeball.pokemon.Name} was killed");
                }
            }
        }

        public void ReturnPokemon(Pokemon pokemon)
        {
            Console.WriteLine($"{Name} has returned their pokemon");
            foreach (Pokeball pokeball in Belt.ToList())
            {
                if (pokeball.pokemon == pokemon)
                {
                    pokeball.Close();
                }
            }
        }

        public Pokemon ChoosePokemon()
        {
            Random rand = new Random();
            int index = rand.Next(0, Belt.Count);
            Pokemon pokemon = Belt[index].pokemon;
            ThrowPokeball(index);

            return pokemon;
        }

        public void countPokemon()
        {
            Console.WriteLine(Name + " has " + Belt.Count + " pokemon left.");
        }
    }
}