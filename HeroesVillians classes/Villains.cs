using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVillians_classes
{
    class Villains:Human
    {
        private string power;
        private string strength;
        private string weakness;
        private string name;
        private string alias;
        private string nemesis;

        public Villains()
        { }
        public Villains(string power, string strength, string weakness, string name, string alias, string nemesis)
        {
            Power = power;
            Strength = strength;
            Weakness = weakness;
            Name = name;
            Alias = alias;
            Nemesis = nemesis;

        }
        public override string Definition()
        {
            return $"{base.Definition()} {Power,-15} {Strength,-15} {Weakness,-4} {Name,-20} {Alias,-10} {Nemesis,-10}";
        }

    }
}
