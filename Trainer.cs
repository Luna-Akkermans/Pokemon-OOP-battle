using System;
using System.Data;

namespace Pokemon_OOP_battle
{
    public class Trainer
    {
        public string Name { get; set; }
        public List<Pokeball> Belt { get; set; }

        public static int trainerOneScore = 0;
        public static int trainerTwoScore = 0;

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

        public void ReturnPokemon(int number)
        {
            Console.WriteLine($"{Name} has returned their pokemon");
            Belt[number].Close();
        }
    }
}