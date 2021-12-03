using System;

namespace Human
{
    public class Wizard : Human
        {
            public Wizard(string name) : base(name, 3, 25, 3, 50)
            {
            }
            
            public override int Attack(Human target)
            {
                int dmg = Intelligence * 3;
                health += dmg;
                target.Health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.Health;
            }

            public int Heal(Human target)
            {
                int heal = Intelligence * 10;
                target.Health += heal;
                Console.WriteLine($"{Name} healed {target.Name}!");
                return target.Health;
            }
        }
}