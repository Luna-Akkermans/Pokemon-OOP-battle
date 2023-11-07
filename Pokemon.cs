namespace Pokemon_OOP_battle
{
    public abstract class Pokemon
    {
        public string Name { get; set; }
        public string Strength { get; set; }
        public string Weakness { get; set; }

        public Pokemon(string name, string strength, string weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;
        }

        public abstract string WarCry();
    }

    public class Squirtle : Pokemon
    {
        public Squirtle(string name) : base(name, "water", "leaf")
        {
        }

        public override string WarCry()
        {
            return $"{Name} yells!";
        }
    }

    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name) : base(name, "grass", "fire")
        {
        }

        public override string WarCry()
        {
            return $"{Name} yells!";
        }
    }
}
