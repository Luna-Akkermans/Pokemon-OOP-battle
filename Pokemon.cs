using System;

namespace Pokemon_OOP_battle
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string WarCry { get; set; }


        //Name Method 
        public void NameChange(string reName)
        {
            Name = reName;
        }
    }
}
