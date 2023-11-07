using System;
using System.Xml.Linq;

namespace Pokemon_OOP_battle
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string strength { get; set; }
        public string weakness { get; set; }


        //Scream Method 
        public string WarCry()
        {
            return Name + " yells!";
        }
    }
}
