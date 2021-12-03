using System;

namespace Human
{
    public class Ninja : Human
        {

            public Ninja(string name) : base(name, 3, 3, 175, 50)
            {
            }

            public override int Attack(Human target)
            {
                int dmg = Dexterity * 5;
                target.Health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.Health;
            }

            public int Steal(Human target)
            {
                target.Health -= 5;
                health +=5;
                return health;
            }

        }

}