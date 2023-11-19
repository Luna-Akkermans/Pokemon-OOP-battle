using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_OOP_battle
{
    public static class Arena
    {
        public static int RoundCount = 1;
        public static int BattleCount = 1;
        public static Trainer lastTrainerWin;
        public static Pokemon FirstActivePokemon = null;
        public static Pokemon SecondActivePokemon = null;
        public static Battle battle = new Battle();

        public static void StartBattle(Trainer firstTrainer, Trainer secondTrainer)
        {
            Console.WriteLine($"\nBATTLE {BattleCount} HAS STARTED\n");
            battle.PerformBattle(firstTrainer, secondTrainer);
        }

        public static void Reset()
        {
            RoundCount = 1;
            FirstActivePokemon = null;
            SecondActivePokemon = null;
        }

        public static void DeclareWinner(Trainer trainer)
        {
            Console.WriteLine(trainer.Name + $" has won the {RoundCount} round!");
            lastTrainerWin = trainer;
        }

        public static void DeclareBattleDraw()
        {
            Console.WriteLine("\nThe battle was a draw.\n");
        }

        public static void DeclareRoundDraw()
        {
            Console.WriteLine($"The {RoundCount} round was a draw");
        }

        public static void endRound()
        {
            Console.WriteLine($"\nRound {RoundCount} has ended.");
            RoundCount += 1;
            Console.WriteLine("\n-------------------------------\n");
        }

        public static void EndBattle(Trainer trainer)
        {
            Console.WriteLine($"The battle is over. {trainer.Name} has won.");
            BattleCount++;
            Reset();
        }
    }
}
