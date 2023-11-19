using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_OOP_battle
{
    public class Pokeball
    {
        public Pokemon pokemon { get; set; }

        public void Open()
        {
            Console.WriteLine("Pokeball opened");
            Console.WriteLine(pokemon.WarCry());
        }

        public void Close()
        {
            Console.WriteLine("The pokeball is closed.");
        }
    }
}
