using System;

namespace Human
{
    public abstract class Human
        {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
        public int Health
            {
                get {return health;}
                set {health = value;}
            }
        public Human(string name, int str, int intl, int dex, int hlth)
            {
                Name = name;
                Strength = str;
                Intelligence = intl;
                Dexterity = dex;
                health = hlth;
            }

        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        
    }

}