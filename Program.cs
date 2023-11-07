using Pokemon_OOP_battle;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool GAME = true;
        while (GAME)
        {
            List<Pokeball> beltOfAsh = new List<Pokeball>
            {
                //Todo:"add extra pokeballs to belt":
                new Pokeball { pokemon = new Pokemon { Name = "Sparky", strength = "Fire", weakness = "Water" } },
                new Pokeball { pokemon = new Pokemon { Name = "Blah", strength = "Fire", weakness = "Water" } },
                new Pokeball { pokemon = new Pokemon { Name = "Pikachu", strength = "Fire", weakness = "Water" } }


            };
            Trainer ash = new Trainer("Ash", beltOfAsh);

            List<Pokeball> beltOfGary = new List<Pokeball>
            {
                //Todo:"add extra pokeballs to belt":
                new Pokeball { pokemon = new Pokemon { Name = "Flufflare", strength = "Fire", weakness = "Water" } },
                new Pokeball { pokemon = new Pokemon { Name = "Aquashade", strength = "Fire", weakness = "Water" } },
                new Pokeball { pokemon = new Pokemon { Name = "Thundertail", strength = "Fire", weakness = "Water" } }
            };
            Trainer gary = new Trainer("Gary", beltOfGary);

            //Ask user for new name of the trainers.
            Console.Write("Enter a name for Ash: ");
            ash.Name = Console.ReadLine();
            Console.Write("Enter a name for Gary: ");
            gary.Name = Console.ReadLine();

            for (int i = 0; i < beltOfAsh.Count; i++)
            {
                ash.ThrowPokeball(i);
                gary.ThrowPokeball(i);
                ash.ThrowPokeball(i);
                gary.ThrowPokeball(i);
            }
        }
    }
}
