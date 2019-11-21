using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVillians_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humanList = new List<Human>()
            //scope of the entire list..hardcoded this way
            {
                //scope of individual index
                {new Heroes( "Super Speed ","above average", "cold","The Flash", "Barry Allen")},
                {new Villains("Plant Power","above average","insanity","Poison Ivy", "Pamela Isley", "Batman") }

           };
            foreach (Human meta in humanList)
            {
                Console.WriteLine(meta.Definition());
            }
            Console.WriteLine("Choose either strength, power, weakness, name, alias, or nemesis");
            string input = Console.ReadLine().ToLower();
            foreach (Human meta in humanList)
            {
                if (meta.Name == input)
                {
                    Console.WriteLine(meta.Power);
                }
            } Console.WriteLine("donedid");


        }
    }
}
