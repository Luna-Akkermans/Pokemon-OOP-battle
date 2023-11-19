using Pokemon_OOP_battle;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initializing 
        bool GAME = true;

        Console.WriteLine("Welcome to the Pokemon Battle Simulator!");
        while (GAME)
        {
            // Ask if they want to start.
            // User gives a name to the first trainer:
            Console.Write("Enter the name for the first trainer: ");
            string firstTrainerName = Console.ReadLine();

            // Create two trainers and fill their betls
            Trainer firstTrainer = new Trainer(firstTrainerName, new List<Pokeball>
            {
               new Pokeball { pokemon = new Squirtle("Squirtle") },
               new Pokeball { pokemon = new Bulbasaur("Bulbasaur") },
               new Pokeball { pokemon = new Charmander("Charmander") }
            });

            Console.Write("Enter a name for the second trainer: ");
            string secondTrainerName = Console.ReadLine();

            Trainer secondTrainer = new Trainer(secondTrainerName, new List<Pokeball>
            {
               new Pokeball { pokemon = new Bulbasaur("Bulbasaur") },
               new Pokeball { pokemon = new Squirtle("Squirtle") },
               new Pokeball { pokemon = new Charmander("Charmander") }
            });

            Arena.StartBattle(firstTrainer, secondTrainer);

            Console.Write("Do you want to play again? (Y/N): ");
            string playAgainResponse = Console.ReadLine();
            if (playAgainResponse.ToUpper() != "Y")
            {
                GAME = false; // Exit the game if the user doesn't want to play again
                Environment.Exit(0);
            }
        }
    }
}
