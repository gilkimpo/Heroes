using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVillians_classes
{
    abstract class Human
    {
        private string power;
        private string strength;
        private string weakness;
        private string name;

        public string Power, Strength, Weakness, Name, Alias, Nemesis;

        

        public virtual string Definition()
        {
            return "You've got : ";
        }
    }
}
    
