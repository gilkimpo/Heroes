using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVillians_classes
{
    class Heroes : Human
    {
        private string power;
        private string strength;
        private string weakness;
        private string name;
        private string alias;

        public string Power
        {
            get { return power; }
            set { power = value; }
        }
        public string Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public Heroes()
        { }
        public Heroes(string power, string strength, string weakness, string name, string alias)
        {
            Power = power;
            Strength = strength;
            Weakness = weakness;
            Name = name;
            Alias = alias;
        }
        public override string Definition()
        {
            return $"{base.Definition()} {Power,-15} {Strength,-15} {Weakness,-4} {Name,-20} {Alias,-10}";
        }


    }
}
