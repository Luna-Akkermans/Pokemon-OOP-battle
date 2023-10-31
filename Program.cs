using Pokemon_OOP_battle;
using System;

class Program
{
static void Main()
    {
        Pokemon charmander = new Pokemon();

        //Starting the game:
        Console.WriteLine("Do you want to start the game?");
        string userInput = Console.ReadLine().ToLower();
        if(userInput == "yes")
        {
            //Start of game
            Console.WriteLine("Let's start by giving the Pokemon a name, what is the name of the pokemon?");
            charmander.Name = Console.ReadLine();

            //Creation of the warcry
            Console.WriteLine($"Let's start by giving {charmander.Name} a warcry, what is the warcry?");
            charmander.WarCry = Console.ReadLine();

            Console.WriteLine($"The {charmander.Name} shouts its warcry:");
            while (true)
            {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(charmander.WarCry);
            }
                //Ask the user if they want to change the name
                Console.WriteLine("Do you wish to change the name?");
                userInput = Console.ReadLine().ToLower();

                //If user wants
                if (userInput == "yes")
                {
                    Console.WriteLine("Enter the new name for your Pokemon:");
                    string newName = Console.ReadLine();
                    charmander.NameChange(newName);
                }
                else if (userInput == "no")
                {
                    Environment.Exit(0);
                }
            }
        }
        else if (userInput == "no")
        {
            Environment.Exit(0);
        }
    }
}