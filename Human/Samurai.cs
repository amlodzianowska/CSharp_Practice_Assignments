using System;

namespace Human
{
    public class Samurai : Human
        {

            public Samurai(string name) : base(name, 3, 3, 3, 200)
            {
            }

            public override int Attack(Human target)
            {
                if (target.Health < 50)
                {
                    target.Health = 0;
                    return target.Health;
                }
                else
                {
                    int dmg = Strength * 3;
                    target.Health -= dmg;
                    Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                    return target.Health;
                }
            }

            public int Meditate()
            {
                health = 200;
                Console.WriteLine($"Samurai {Name} meditated and is fully healed!");
                return health;
            }

        }

}