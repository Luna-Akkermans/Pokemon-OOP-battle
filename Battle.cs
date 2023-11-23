namespace Pokemon_OOP_battle
{
    public class Battle
    {
        Random random = new Random();

        public int previousWinner = 0;
        public bool tie = true;
        public int currentIndex = 0;

        public static string firstTrainerName;
        public static string secondTrainerName;
        static bool GAME = true;

        public static void Start()
        {
            // Initializing 
            Battle battle = new Battle();

            Console.WriteLine("Welcome to the Pokemon Battle Simulator!");
            while (GAME)
            {
                firstTrainerName = TrainerName("Enter the name for the first trainer: ");
                secondTrainerName = TrainerName("Enter a name for the second trainer: ");

                Trainer firstTrainer = AssignTrainer(firstTrainerName);
                Trainer secondTrainer = AssignTrainer(secondTrainerName);

                while (Arena.CheckScore(Trainer.trainerOneScore, Trainer.trainerTwoScore))
                {
                    // Alternate between trainers for each Pokeball
                    for (int pokeballIndex = 0; pokeballIndex < firstTrainer.Belt.Count; pokeballIndex++)
                    {
                        battle.PerformBattle(firstTrainer, secondTrainer);
                        Console.WriteLine("---------------------");
                        Arena.SetScore();
                        Thread.Sleep(2000);
                    }
                }

                if (Arena.WhoWon(Trainer.trainerOneScore, Trainer.trainerTwoScore)) Console.WriteLine($"{firstTrainerName} won with {Trainer.trainerOneScore} points!");
                else Console.WriteLine($"{secondTrainerName} won with {Trainer.trainerTwoScore} points!");

                GAME = Arena.AskPlayAgain();
            }
        }

        public void PerformBattle(Trainer firstTrainer, Trainer secondTrainer)
        {
            if (previousWinner == 1) KeepPokemon(currentIndex, firstTrainer, GenerateRandomIndex(secondTrainer), secondTrainer);
            if (previousWinner == 2) KeepPokemon(GenerateRandomIndex(firstTrainer), firstTrainer, currentIndex, secondTrainer);
            if (tie) KeepPokemon(GenerateRandomIndex(firstTrainer), firstTrainer, GenerateRandomIndex(secondTrainer), secondTrainer);
        }

        /// <summary>
        /// Chech the winner, keep the winners pokemon on the battlefield.
        /// </summary>
        void KeepPokemon(int indexOne, Trainer trainer, int indexTwo, Trainer trainerTwo)
        {
            try
            {
                if (previousWinner == 1) ThrowIntoBattle(trainerTwo, indexTwo);
                else if (previousWinner == 2) ThrowIntoBattle(trainer, indexOne);
                else
                {
                    ThrowIntoBattle(trainer, indexOne);
                    ThrowIntoBattle(trainerTwo, indexTwo);
                }
                DetermineWinner(indexOne, trainer, indexTwo, trainerTwo);

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Put the pokemon in the battle.
        /// </summary>
        static void ThrowIntoBattle(Trainer trainer, int index)
        {
            try
            {
                Console.WriteLine(trainer.Name);
                Console.WriteLine("Opens");
                trainer.ThrowPokeball(index);
                trainer.Belt[index].pokemon.WarCry();
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Generate a random index integer picking between 0 and the count of Belt
        /// </summary>
        int GenerateRandomIndex(Trainer trainer)
        {
            return random.Next(0, trainer.Belt.Count);
        }

        /// <summary>
        /// Check which pokemon wins. Change stats according to it.
        /// </summary>
        public void DetermineWinner(int indexPokemon, Trainer trainerOne, int indexPokemon2, Trainer trainerTwo)
        {
            Pokemon pokemonOne = trainerOne.Belt[indexPokemon].pokemon;
            Pokemon pokemonTwo = trainerTwo.Belt[indexPokemon2].pokemon;

            if (pokemonOne.Strength == pokemonTwo.Weakness && pokemonOne.Weakness == pokemonTwo.Strength)
            {
                ShowStatus("It's a draw! Both Pokémons are strong against each other! ------ Returning both pokemons!", ConsoleColor.Yellow);
                tie = true;
            }
            else if (pokemonOne.Strength == pokemonTwo.Weakness)
            {
                ShowStatus($"{pokemonOne.Name} from {trainerOne.Name} won vs {pokemonTwo.Name} from {trainerTwo.Name}", ConsoleColor.Green);
                ShowStatus($"Keeping {pokemonOne.Name}", ConsoleColor.Green);
                ShowStatus($"Returning {pokemonTwo.Name}", ConsoleColor.Red);

                previousWinner = 1; 
                currentIndex = indexPokemon;
                Trainer.trainerOneScore++;
            }
            else if (pokemonOne.Weakness == pokemonTwo.Strength)
            {
                ShowStatus($"{pokemonTwo.Name} from {trainerTwo.Name} won vs {pokemonOne.Name} from {trainerOne.Name}", ConsoleColor.Green);

                ShowStatus($"Returning {pokemonOne.Name}", ConsoleColor.Red);

                previousWinner = 2;
                currentIndex = indexPokemon2;
                Trainer.trainerTwoScore++;
            }
            else
            {
                ShowStatus("No clear advantage. It's a tie! ------ Returning both pokemons!", ConsoleColor.Yellow);
                tie = true;
            }
        }

        /// <summary>
        /// Ask for the trainer name, then return it.
        /// </summary>
        static string TrainerName(string message)
        {
            Console.Write(message);
            string trainername = Console.ReadLine();
            return trainername;
        }

        /// <summary>
        /// Assign pokemons to the given trainer.
        /// </summary>
        /// <param name="trainername"></param>
        static Trainer AssignTrainer(string trainername)
        {
            Trainer trainer = new Trainer(trainername, new List<Pokeball>
            {
                new Pokeball { pokemon = new Bulbasaur("Bulbasaur") },
                new Pokeball { pokemon = new Squirtle("Squirtle") },
                new Pokeball { pokemon = new Charmander("Charmander")}
            });

            return trainer;
        }

        /// <summary>
        /// Telling the user which trainer won, showing the text in color 'textColor'.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        private static void ShowStatus(string message, ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}