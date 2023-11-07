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

        public void ReturnPokemon(int number)
        {
            Console.WriteLine($"{Name} has returned their pokemon");
            Belt[number].Close();
        }
    }
}