using System;

namespace DemoTwo
{
    public class Warrior : Character
    {
        public Warrior(string n) : base(n)
        {
            name = n;
            strength = 20;
            intelligence = 8;
            health = 110;
        }

        public override void attack()
        {
            Console.WriteLine($"{name} launched an attack!")
        }

    }
    
    
}