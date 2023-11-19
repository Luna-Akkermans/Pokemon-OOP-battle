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
            while (firstTrainer.Belt.Count > 0 && secondTrainer.Belt.Count > 0)
            {
                if (Arena.lastTrainerWin == firstTrainer) //randomly throw a pokemon from the belt
                {
                    Arena.SecondActivePokemon = secondTrainer.ChoosePokemon();

                }
                else if (Arena.lastTrainerWin == secondTrainer)
                {
                    Arena.FirstActivePokemon = firstTrainer.ChoosePokemon();
                }
                else
                {
                    Arena.FirstActivePokemon = firstTrainer.ChoosePokemon();
                    Arena.SecondActivePokemon = secondTrainer.ChoosePokemon();
                }

                //The two active pokemon attack
                Console.WriteLine(Arena.FirstActivePokemon.Attack());
                Console.WriteLine(Arena.SecondActivePokemon.Attack());


                //if the first pokemon beats the second
                if (Arena.FirstActivePokemon.Strength == Arena.SecondActivePokemon.Weakness)
                {
                    Arena.DeclareWinner(firstTrainer);
                    secondTrainer.KillPokemon(Arena.SecondActivePokemon);
                    Arena.SecondActivePokemon = null; //makes it so the pokemon isn't active inside of the arena anymore

                }

                //if the second pokemon beats the first
                else if (Arena.FirstActivePokemon.Weakness == Arena.SecondActivePokemon.Strength)
                {
                    Arena.DeclareWinner(secondTrainer);
                    firstTrainer.KillPokemon(Arena.FirstActivePokemon);
                    Arena.FirstActivePokemon = null; ////makes it so the pokemon isn't active inside of the arena anymore

                }

                //if its a draw
                else
                {
                    if (firstTrainer.Belt.Count == 1 && secondTrainer.Belt.Count == 1) //if none of the pokemon can beat one another, end the battle as a draw
                    {
                        Arena.DeclareBattleDraw();
                        break;
                    }



                    if (Arena.RoundCount == 1) //if the draw was in the first round
                    {
                        Arena.DeclareRoundDraw();
                        firstTrainer.ReturnPokemon(Arena.FirstActivePokemon);
                        secondTrainer.ReturnPokemon(Arena.SecondActivePokemon);
                    }
                    else if (Arena.RoundCount > 1) //if the draw was not in the first round
                    {
                        Arena.DeclareRoundDraw();
                        if (Arena.lastTrainerWin == firstTrainer)
                        {
                            firstTrainer.ReturnPokemon(Arena.FirstActivePokemon);
                        }
                        else if (Arena.lastTrainerWin == secondTrainer)
                        {
                            secondTrainer.ReturnPokemon(Arena.SecondActivePokemon);
                        }
                    }
                }

                //count pokemon
                Console.WriteLine("\n");
                firstTrainer.countPokemon();
                Console.WriteLine("\n");
                secondTrainer.countPokemon();

                //end the round
                Arena.endRound();

                //if one of the trainers have lost all pokemon, end the battle.
                if (firstTrainer.Belt.Count == 0)
                {
                    Arena.EndBattle(firstTrainer);
                }

                else if (secondTrainer.Belt.Count == 0)
                {
                    Arena.EndBattle(secondTrainer);
                }
            }
        }
    }
}
