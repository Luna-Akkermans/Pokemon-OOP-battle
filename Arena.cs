namespace Pokemon_OOP_battle
{
    internal class Arena
    {
        static readonly int maxScore = 5;

        public static void SetScore()
        {
            Console.Title = $"{Battle.firstTrainerName}: {Trainer.trainerOneScore} | {Battle.secondTrainerName}: {Trainer.trainerTwoScore}";
        }

        /// <summary>
        /// Check for scoreOne & scoreTwo which of those two is highest.
        /// </summary>
        /// <returns>The winning trainer</returns>
        public static bool CheckScore(int scoreOne, int scoreTwo)
        {
            if (scoreOne == maxScore) return false;
            if (scoreTwo == maxScore) return false;
            return true;
        }


        /// <summary>
        /// Ask if the player want to play again
        /// </summary>
        public static bool AskPlayAgain()
        {
            Console.Write("Do you want to play again? (Y/N): ");
            string playAgainResponse = Console.ReadLine();
            Trainer.trainerOneScore = 0;
            Trainer.trainerTwoScore = 0;

            if (playAgainResponse.ToUpper() == "Y")
            {
                Console.Clear();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determine who won by comparing scores.
        /// </summary>
        public static bool WhoWon(int one, int two)
        {
            if (one > two) return true;
            return false;
        }
    }
}
