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
        public abstract string Attack();
    }

    public class Squirtle : Pokemon
    {
        public Squirtle(string name) : base(name, "water", "grass")
        {
        }

        public override string WarCry()
        {
            return $"{Name} yells!";
        }

        public override string Attack()
        {
            return $"{Name} attacks!";
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

        public override string Attack()
        {
            return $"{Name} attacks!";
        }
    }

    public class Charmander : Pokemon
    {
        public Charmander(string name) : base(name, "fire", "water")
        {
        }

        public override string WarCry()
        {
            return $"{Name} yells!";
        }

        public override string Attack()
        {
            return $"{Name} attacks!";
        }
    }
}
