using System;

namespace Human
{
    public class Human
        {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
            {
                get {return health;}
            }

        public Human(string name, int str, int intl, int dext, int hlth)
            {
                Name = name;
                Strength = str;
                Intelligence = intl;
                Dexterity = dext;
                health = hlth;
            }
        public Human(string name)
            {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
            }
        public int Attack(Human target)
        {
            target.health -= Strength*5;
            Console.WriteLine($"{Name} attacked {target.Name}!");
            Console.WriteLine($"{target.Name}'s health is now {target.health}!");
            return target.health;
        }

        }

}