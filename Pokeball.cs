namespace Pokemon_OOP_battle
{
    public class Pokeball
    {
        public Pokemon pokemon { get; set; }

        public void Open()
        {
            try
            {
                Console.WriteLine("Pokeball opened");
                Console.WriteLine(pokemon.WarCry());
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void Close()
        {
            Console.WriteLine("The pokeball is closed.");
        }
    }
}
